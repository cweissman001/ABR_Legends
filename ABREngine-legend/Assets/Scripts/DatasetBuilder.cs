using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using VTK;
using System.Linq;

public class DatasetBuilder
{
    public static Dataset BuildMeshArrays(VTK.vtkDataSet vtkDataset)
    {
        Vector3[] vertexArray;
        Dictionary<string, float[]> scalarArrays = new Dictionary<string, float[]>();
        Dictionary<string, float> scalarMins = new Dictionary<string, float>();
        Dictionary<string, float> scalarMaxes = new Dictionary<string, float>();

        Dictionary<string, Vector3[]> vectorArrays = new Dictionary<string, Vector3[]>();

        int[] indexArray;
        int[] cellIndexStarts;
        int[] cellIndexCounts;

        MeshTopology meshTopology = MeshTopology.Points;

        VTK.vtkIdList cellIdList = VTK.vtkIdList.New();
        VTK.vtkPoints cellPointList = VTK.vtkPoints.New();

        // ThreadDebug("BuildingMeshArrays");
        long numCells = vtkDataset.GetNumberOfCells();
        long numPoints = vtkDataset.GetNumberOfPoints();

        //if (numCells == 0) { return null; }
        if (vtkDataset.IsA("vtkUnstructuredGrid") == false) { return null; }



        vtkUnstructuredGrid unstructuredData = vtkUnstructuredGrid.SafeDownCast(vtkDataset);
        VTKCellType firstCellType;
        if (numCells == 0) firstCellType = VTKCellType.VTK_EMPTY_CELL;
        else
            firstCellType  = (VTK.VTKCellType)unstructuredData.GetCell(0).GetCellType();

        switch (firstCellType)
        {
            case VTKCellType.VTK_VERTEX:
                meshTopology = MeshTopology.Points;
                break;
            case VTKCellType.VTK_POLY_VERTEX:
                meshTopology = MeshTopology.Points;
                break;
            case VTKCellType.VTK_POLY_LINE:
                meshTopology = MeshTopology.LineStrip;
                break;
            case VTKCellType.VTK_LINE:
                meshTopology = MeshTopology.Lines;
                break;
            case VTKCellType.VTK_QUAD:
                meshTopology = MeshTopology.Quads;
                break;
            case VTKCellType.VTK_TRIANGLE:
                meshTopology = MeshTopology.Triangles;
                break;
            default:
                meshTopology = MeshTopology.Points;
                break;
        }


        // var normalVtkArray = unstructuredData.GetPointData().GetAbstractArray("Normals");
        Vector3[] polyPoints = new Vector3[unstructuredData.GetNumberOfPoints()];
        const int FLOAT_TYPE = 10;
        const int DOUBLE_TYPE = 11;
        float[] polyPointElements = new float[unstructuredData.GetNumberOfPoints() * 3];
        if(unstructuredData.GetNumberOfPoints() != 0)
        {
            if (unstructuredData.GetPoints().GetDataType() == FLOAT_TYPE)
            {
                Marshal.Copy(unstructuredData.GetPoints().GetVoidPointer(0), polyPointElements, 0, (int)polyPointElements.Length);
            } else if (unstructuredData.GetPoints().GetDataType() == DOUBLE_TYPE)
            {
                double[] doublePolyPointElements = new double[unstructuredData.GetNumberOfPoints() * 3];
                Marshal.Copy(unstructuredData.GetPoints().GetVoidPointer(0), doublePolyPointElements, 0, (int)polyPointElements.Length);
                for (int i = 0; i < polyPointElements.Length; i++) polyPointElements[i] = (float)doublePolyPointElements[i];

            }
        }

        vtkPointData pointData = unstructuredData.GetPointData();
        int numArrays = pointData.GetNumberOfArrays();
        vtkAbstractArray abstractArray = null;
        string arrayName = "";
        for (int i = 0; i < numArrays; i++)
        {
            try { arrayName = pointData.GetArrayName(i);
                if (arrayName.Contains("\0"))
                    arrayName = arrayName.Substring(0, System.Math.Max(0, arrayName.IndexOf('\0')));
                abstractArray = pointData.GetAbstractArray(i);
                if (abstractArray.GetNumberOfComponents() == 1)
                {
                    float[] array = GetFloatArray(abstractArray);
                    scalarArrays[arrayName] = array;
                    scalarMins[arrayName] = GetMin(abstractArray);
                    scalarMaxes[arrayName] = GetMax(abstractArray);

                }
                else // 3-vec, probably?
                {
                    Vector3[] array = GetVectorArray(abstractArray);
                    vectorArrays[arrayName] = array;
                }
            }
            catch { }
            
           
        }
        // Flip the z component of vector assuming it's a 3-vec. 
        // This also is based on the assumption that a 3-vec represents 
        // something spatial, and that Paraview is right-handed and 
        // Unity is left-handed. 
        if (true /*flip z component */)
        {
            for (int i = 0; i < polyPointElements.Length / 3; i++)
            {
                //Swap(ref polyPointElements[i*3+2], ref polyPointElements[i*3+1] );
                polyPointElements[i * 3 + 2] *= -1;

            }
        }


        for (int i = 0; i < polyPoints.Length; i++)
        {
            polyPoints[i][0] = polyPointElements[i * 3 + 0];
            polyPoints[i][1] = polyPointElements[i * 3 + 1];
            polyPoints[i][2] = polyPointElements[i * 3 + 2];
            if (System.Single.IsNaN(polyPoints[i].x))
            {
                polyPoints[i].x = 0;
            }
            if (System.Single.IsNaN(polyPoints[i].y))
            {
                polyPoints[i].y = 0;
            }
            if (System.Single.IsNaN(polyPoints[i].z))
            {
                polyPoints[i].z = 0;
            }
        }

        vertexArray = polyPoints;
        // vertexList.AddRange(polyPoints);
        // if(normalVtkArray != null && !normalVtkArray.IsVoid())
        // normalArray = GetVectorArray(normalVtkArray); 

        long numIndices = 0;
        switch (meshTopology)
        {
            case (MeshTopology.Points):
                numIndices = numPoints;
                break;
            case (MeshTopology.Lines):
                numIndices = numCells * 2;
                break;
            case (MeshTopology.LineStrip):
                numIndices = numPoints;
                break;
            case (MeshTopology.Triangles):
                numIndices = numCells * 3;
                break;
            case (MeshTopology.Quads):
                numIndices = numCells * 4;
                break;
            default:
                break;
        }
        indexArray = new int[numIndices];

        int index = 0;


        cellIndexStarts = new int[numCells];
        cellIndexCounts = new int[numCells];

        for (long c = 0; c < numCells; c++)
        {
            unstructuredData.GetCellPoints(c, cellIdList);
            long cellIndexCount = cellIdList.GetNumberOfIds();


            cellIndexStarts[c] = index;
            cellIndexCounts[c] = (int)cellIndexCount;
            if (false && meshTopology == MeshTopology.Quads || meshTopology == MeshTopology.Triangles)
            {

                // Flip the winding order of the polygons. 
                // This also is based on the assumption that Paraview is 
                // right-handed and Unity is left-handed.
                for (long p = cellIndexCount - 1; p >= 0; p--)
                {
                    long pointId = cellIdList.GetId(p);

                    indexArray[index] = (int)pointId;

                    index++;
                }
            }
            else
            {
                try
                {
                    for (long p = 0; p < cellIndexCount; p++)
                    {
                        long pointId = cellIdList.GetId(p);
                        indexArray[index] = (int)pointId;
                        index++;

                    }
                }
                catch { }

            }

        }
        Dataset dataset = new Dataset
        {
            bounds = vtkDataset.GetBounds(),
            vertexArray = vertexArray,
            indexArray = indexArray,
            cellIndexOffsets = cellIndexStarts,
            cellIndexCounts = cellIndexCounts,
            meshTopology = meshTopology,
            scalarArrayNames = scalarArrays.Keys.ToArray(),
            vectorArrayNames = vectorArrays.Keys.ToArray(),
            //scalarArrays = scalarArrays.Values.ToArray(),
            scalarMins = scalarMins.Values.ToArray(),
            scalarMaxes = scalarMaxes.Values.ToArray()//,
            //vectorArrays = vectorArrays.Values.ToArray()
        };
        dataset.scalarArrays = new SerializableFloatArray[scalarArrays.Count];
        var scalarArraysArray = scalarArrays.Values.ToArray();

        for (int i = 0; i < dataset.scalarArrays.Count(); i++)
        {
            dataset.scalarArrays[i] = new SerializableFloatArray();
            dataset.scalarArrays[i].array = scalarArraysArray[i];
        }

        dataset.vectorArrays = new SerializableVectorArray[vectorArrays.Count];
        var vectorArraysArray = vectorArrays.Values.ToArray();

        for (int i = 0; i < dataset.vectorArrays.Count(); i++)
        {
            dataset.vectorArrays[i] = new SerializableVectorArray();
            dataset.vectorArrays[i].array = vectorArraysArray[i];
        }


        return dataset;



    }


    public static float GetMin(VTK.vtkAbstractArray abstractArray)
    {
        float min = float.MinValue;
        double[] range = new double[2];
        if (abstractArray.IsA("vtkFloatArray"))
        {
            vtkFloatArray.FastDownCast(abstractArray).GetRange(range, 0);

        }
        else if (abstractArray.IsA("vtkDoubleArray"))
        {
            vtkDoubleArray.FastDownCast(abstractArray).GetRange(range, 0);

        }
        else if (abstractArray.IsA("vtkIntArray"))
        {
            vtkIntArray.FastDownCast(abstractArray).GetRange(range, 0);
        }
        min = (float)range[0];

        return min;
    }

    public static float GetMax(VTK.vtkAbstractArray abstractArray)
    {
        float max = float.MinValue;
        double[] range = new double[2];
        if (abstractArray.IsA("vtkFloatArray"))
        {
            vtkFloatArray.FastDownCast(abstractArray).GetRange(range, 0);

        }
        else if (abstractArray.IsA("vtkDoubleArray"))
        {
            vtkDoubleArray.FastDownCast(abstractArray).GetRange(range, 0);

        }
        else if (abstractArray.IsA("vtkIntArray"))
        {
            vtkIntArray.FastDownCast(abstractArray).GetRange(range, 0);
        }
        max = (float)range[1];

        return max;
    }

    // Utility function for extracting a float array out of a vtk DataArray
    public static float[] GetFloatArray(VTK.vtkAbstractArray abstractArray)
    {
        long numberOfElements = abstractArray.GetNumberOfTuples();
        long numberOfComponents = abstractArray.GetNumberOfComponents();


        float[] floatData = new float[numberOfElements * numberOfComponents];

        if (abstractArray.IsA("vtkFloatArray"))
        {
            Marshal.Copy(abstractArray.GetVoidPointer(0), floatData, 0, (int)floatData.Length);

        }
        else if (abstractArray.IsA("vtkDoubleArray"))
        {
            double[] doubleData = new double[numberOfComponents * numberOfElements];

            Marshal.Copy(abstractArray.GetVoidPointer(0), doubleData, 0, (int)doubleData.Length);
            for (int i = 0; i < doubleData.Length; i++)
                floatData[i] = (float)doubleData[i];
        }
        else if (abstractArray.IsA("vtkIntArray"))
        {
            int[] intData = new int[numberOfComponents * numberOfElements];
            Marshal.Copy(abstractArray.GetVoidPointer(0), intData, 0, (int)intData.Length);

            for (int i = 0; i < intData.Length; i++)
                floatData[i] = (float)intData[i];


        }
        else if (abstractArray.IsA("vtkUnsignedCharArray"))
        {
            byte[] byteData = new byte[numberOfComponents * numberOfElements];
            Marshal.Copy(abstractArray.GetVoidPointer(0), byteData, 0, (int)byteData.Length);

            for (int i = 0; i < byteData.Length; i++)
                floatData[i] = (float)byteData[i];
        }

        // Flip the z component of vector assuming it's a 3-vec. 
        // This also is based on the assumption that a 3-vec represents 
        // something spatial, and that Paraview is right-handed and 
        // Unity is left-handed. 
        if (numberOfComponents > 2)
        {
            for (int i = 0; i < floatData.Length / numberOfComponents; i++)
            {
                //Swap(ref floatData[i*numberOfComponents+2], ref floatData[i*numberOfComponents+1]);
                floatData[i * numberOfComponents + 2] *= -1;
            }
        }

        return floatData;
    }


    // Utility function for extracting a vector array out of a vtk DataArray
    // For example, getting normals. 
    public static Vector3[] GetVectorArray(VTK.vtkAbstractArray abstractArray)
    {
        long numberOfElements = abstractArray.GetNumberOfTuples();
        long numberOfComponents = abstractArray.GetNumberOfComponents();
        Vector3[] vectorData = new Vector3[numberOfElements];
        float[] floatData = GetFloatArray(abstractArray);
        for (int i = 0; i < numberOfElements; i++)
        {
            for (int c = 0; c < numberOfComponents; c++)
            {
                vectorData[i][c] = floatData[i * numberOfComponents + c];

            }
        }

        return vectorData;

    }

    // Utility function for swaping
    public static void Swap<T>(ref T lhs, ref T rhs)
    {
        T temp = lhs;
        lhs = rhs;
        rhs = temp;
    }
}
