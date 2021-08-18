using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using IVLab.Utilities.GenericObjectPool;

[EncodingStrategy("Surface", EncodingStrategyAttribute.DataType.Surface)]
public class SimpleSurfaceEncodingRenderStrategy : EncodingRenderStrategy
{


    //[ABRInput("Solid Color")]
    //public readonly IAssignable<Color> colorField = Color.white;


    [ABRInput("Color Variable", "Color", "White")]
    public readonly IScalarDataVariable colorVariable;


    [ABRInput("Colormap", "Color", "", "If no variable is selected, the middle of the colormap will be used")]
    public readonly IColormap colormap;

    // [ABRInput("Normal Variable", "Surface Normal")]
    public readonly IVectorDataVariable normalVariable;



    [ABRInput("Pattern", "Surface Pattern", "", "Pattern to overlay on the surface")]
    public readonly ISurfaceTexture pattern;



    // [ABRInput("Pattern Variable", "Surface Pattern", "", "Variable to control which pattern is used", false)]
    public readonly IScalarDataVariable patternVariable;

    [ABRInput("Pattern Scale", "Pattern Scale", "100%", "How big to make the pattern")]
    public readonly RealNumber patternScale;


    [ABRInput("Pattern Blend", "Pattern Blend", "100%", "Blend the seams of texture together", true)]
    public readonly RealNumber patternDirectionBlend;

    [ABRInput("Pattern Saturation", "Pattern Saturation", "100%", "Saturation of pattern")]
    public readonly RealNumber patternSaturation;

    [ABRInput("Pattern Intensity", "Pattern Intensity", "100%", "Intensity of pattern")]
    public readonly RealNumber patternIntensity;



    bool backFace = true;

    public class SimpleSurfaceRenderInfo : DataObjectRenderInfo, EncodingRenderInfo
    {

        public Vector3[] vertices;
        public int[] indices;
        public Vector3[] normals;
        public Color[] scalars;
        public Vector4 scalarMin;
        public Vector4 scalarMax;
        public MeshTopology topology;
        public float meshScale;
    }


    MaterialPropertyBlock block;
    Material material;

    const string materialName = "ABR_DataColoredMesh";

    public SimpleSurfaceEncodingRenderStrategy() : base()
    {
        block = new MaterialPropertyBlock();
        material = Resources.Load<Material>(materialName);

    }

    public override EncodingRenderInfo ComputeEncodingDataForEncodedObject(EncodedObject encodedObject)
    {
        return encodedObject.Encoding.dataObjectRenderInfo as EncodingRenderInfo;
    }


    public override DataObjectRenderInfo ComputeDataForDataObject(IDataObject dataObject)
    {
        SimpleSurfaceRenderInfo renderInfo = null;
        Dataset dataset = dataObject?.dataset;

        if (dataset == null || this.Hidden)
        {
            renderInfo = new SimpleSurfaceRenderInfo
            {
                vertices = new Vector3[0],
                normals = null,
                indices = new int[0],
                scalars = new Color[0],
                topology = MeshTopology.Points
            };
        }
        else
        {

            int sourceVertCount = dataset.vertexArray.Length;
            int sourceIndexCount = dataset.indexArray.Length;

            int numPoints = sourceVertCount;
            int numIndices = sourceIndexCount;

            if (backFace == true)
            {
                numPoints *= 2;
                numIndices *= 2;
            }


            renderInfo = new SimpleSurfaceRenderInfo
            {
                vertices = new Vector3[numPoints],
                indices = new int[numIndices],
                scalars = new Color[numPoints],
                normals = null,
                scalarMin = Vector4.zero,
                scalarMax = Vector4.zero,
                topology = dataset.meshTopology

            };

            renderInfo.meshScale = 1;
            if (dataset.bounds.size.magnitude > 10000)
                renderInfo.meshScale /= 10000;




            int numCells = dataset.cellIndexCounts.Length;
            int cellSize = dataset.meshTopology == MeshTopology.Quads ? 4 : 3;

            for (int i = 0; i < sourceVertCount; i++)
                renderInfo.vertices[i] = dataset.vertexArray[i]* renderInfo.meshScale;
            
            // Backfaces 
            for (int i = sourceVertCount, j = 0; i < numPoints; i++, j++)
                renderInfo.vertices[i] = dataset.vertexArray[j] * renderInfo.meshScale;


            Vector3[] dataNormals = null;
            Vector3[] meshNormals = null;
            if (ABRManager.IsValidNode(normalVariable))
            {
                dataNormals = normalVariable.GetVectorArray(dataset);
            }
            //else if((generateNormals?.floatVal??0) <= 0.0f)
            //{
            //    dataNormals = dataset.GetVectorArray("Normals");
            //}

            if (dataNormals != null)
            {
                renderInfo.normals = new Vector3[numPoints];

                for (int i = 0; i < sourceVertCount; i++)
                    renderInfo.normals[i] = dataNormals[i];

                // Backfaces 
                for (int i = sourceVertCount, j = 0; i < numPoints; i++, j++)
                    renderInfo.normals[i] = -dataNormals[j];

            }


            if (ABRManager.IsValidNode(colorVariable))
            {
                var colorScalars = colorVariable.GetScalarArray(dataset);
                for (int i = 0; i < sourceVertCount; i++)
                    renderInfo.scalars[i][0] = colorScalars[i];

                // Back faces
                for (int i = sourceVertCount, j = 0; i < numPoints; i++, j++)
                    renderInfo.scalars[i][0] = colorScalars[j];

                renderInfo.scalarMin[0] = colorVariable.GetScalarMin();
                renderInfo.scalarMax[0] = colorVariable.GetScalarMax();
            }


            if (ABRManager.IsValidNode(patternVariable))
            {
                var scalars = patternVariable.GetScalarArray(dataset);
                for (int i = 0; i < sourceVertCount; i++)
                    renderInfo.scalars[i][1] = scalars[i];

                // Back faces
                for (int i = sourceVertCount, j = 0; i < numPoints; i++, j++)
                    renderInfo.scalars[i][1] = scalars[j];

                renderInfo.scalarMin[1] = patternVariable.GetScalarMin();
                renderInfo.scalarMax[1] = patternVariable.GetScalarMax();

            }

            for (int c = 0, i = 0; c < numCells; c++)
            {
                for (int p = 0; p < cellSize; p++, i++)
                {
                    renderInfo.indices[i] = dataset.indexArray[i];

                   
                }

            }


            //meshIndices[(i + numCells) * cellSize + j] = dataset.indexArray[(i) * cellSize + (cellSize - 1 - j)] + dataset.vertexArray.Length;

            
            if (backFace)
            for (int c = 0, i = sourceIndexCount; c < numCells; c++)
            {
                for (int p = 0, rev_p = cellSize - 1; p < cellSize; p++,rev_p--, i++)
                {
                    
                    renderInfo.indices[i] = dataset.indexArray[c * cellSize + rev_p] + sourceVertCount;


                }

            }


        }

        return renderInfo;
    }

   
    public override EncodedObject MakeEncodedGameObject(EncodedObject currentGameObject)
    {

        var SSrenderData = currentGameObject.encodingRenderInfo as SimpleSurfaceRenderInfo;

        //if(SSrenderData == null || dataObject == null || currentGameObject == null)
        if (currentGameObject == null)
        {
            //Debug.LogError("Something is wrong.");


            return currentGameObject;
        }

        MeshFilter meshFilter;
        MeshRenderer meshRenderer;

        meshFilter = currentGameObject.GetComponent<MeshFilter>();
        meshRenderer = currentGameObject.GetComponent<MeshRenderer>();

        if (meshFilter == null)
        {
            meshFilter = currentGameObject.gameObject.AddComponent<MeshFilter>();

        } 
        if (meshRenderer == null)
        {
            meshRenderer = currentGameObject.gameObject.AddComponent<MeshRenderer>();
        }

        currentGameObject.gameObject.layer = LayerMask.NameToLayer("Surface");


        currentGameObject.name = this + " surface Mesh";

        if (SSrenderData != null)
        {
            Mesh mesh = meshFilter.mesh;
            if (mesh == null) mesh = new Mesh();
            mesh.Clear();
            mesh.name = "SSS:278@" + System.DateTime.Now.ToString();

            mesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;
            mesh.vertices = SSrenderData.vertices;
            mesh.colors = SSrenderData.scalars;
            mesh.SetIndices(SSrenderData.indices, SSrenderData.topology, 0);
            if (SSrenderData.normals != null)
            {
                mesh.normals = SSrenderData.normals;

            }
            else
            {
                mesh.RecalculateNormals();
            }
            mesh.RecalculateTangents();
            mesh.UploadMeshData(false);

            meshFilter.mesh = mesh;

            meshRenderer.material = material;

            meshRenderer.GetPropertyBlock(block);
            block.SetColor("_Color", Color.white);
            block.SetFloat("_ColorDataMin", SSrenderData.scalarMin[0]);
            block.SetFloat("_ColorDataMax", SSrenderData.scalarMax[0]);
            block.SetFloat("_PatternDataMin", SSrenderData.scalarMin[1]);
            block.SetFloat("_PatternDataMax", SSrenderData.scalarMax[1]);

            block.SetFloat("_DataDimension", currentGameObject.dataScene.GetDataBounds().size.magnitude * SSrenderData.meshScale);
            if(ABRManager.IsValidNode(patternIntensity))
            {
                block.SetFloat("_PatternIntensity", patternIntensity.floatVal);

            }
            else
            {
                block.SetFloat("_PatternIntensity", 1);
            }
            if (ABRManager.IsValidNode(patternScale))
            {
                block.SetFloat("_PatternScale", patternScale.floatVal);

            }
            else
            {
                block.SetFloat("_PatternScale",1);
            }
                    
            if (ABRManager.IsValidNode(patternDirectionBlend))
            {
                block.SetFloat("_PatternDirectionBlend", patternDirectionBlend.floatVal);

            }
            else
            {
                block.SetFloat("_PatternDirectionBlend", 1);
            }

                              
            if (ABRManager.IsValidNode(patternSaturation))
            {
                block.SetFloat("_PatternSaturation", patternSaturation.floatVal);

            }
            else
            {
                block.SetFloat("_PatternSaturation", 1);
            }


            if(ABRManager.IsValidNode(patternVariable))
            {
                block.SetInt("_UsePatternVariable", 1);
            } else
            {
                block.SetInt("_UsePatternVariable", 0);

            }
            if (colormap?.GetColorGradient() != null)
            {
                block.SetInt("_UseColorMap", 1);
                block.SetTexture("_ColorMap", colormap?.GetColorGradient());
            }
            else
            {
                block.SetInt("_UseColorMap", 0);
            }
            try
            {
                if (pattern?.GetTexture() != null)
                {
                    block.SetInt("_UsePattern", 1);
                    block.SetTexture("_Pattern", pattern?.GetTexture());
                    block.SetTexture("_PatternNormal", pattern?.GetTexture());

                }
                else
                {
                    block.SetInt("_UsePattern", 0);
                    block.SetTexture("_Pattern", VisAssetManager.GetDefaultAlbedo());
                    block.SetTexture("_PatternNormal", VisAssetManager.GetDefaultNormal());

                }
            } catch(Exception e)
            {
                Debug.LogError(e);
            }

            meshRenderer.SetPropertyBlock(block);
        }
        else
        {


        }

        if(SSrenderData!= null && SSrenderData.meshScale > 0) currentGameObject.transform.localScale = Vector3.one/SSrenderData.meshScale;

        return currentGameObject;
    }

    public override void RecycleEncodedGameObject(EncodedObject encodedObject)
    {
        if (this.GetType().IsAssignableFrom(encodedObject.Encoding.renderingStrategy.GetType()) == false)
        {
            Debug.LogError("Encoded Object wasn't made with this render strategy");
            GameObject.Destroy(encodedObject);
            return;
        }

        GenericObjectPool.Instance.ReturnObjectToPool(encodedObject.gameObject);

    }

    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        base.ReceiveMessage(message);
    }


}
