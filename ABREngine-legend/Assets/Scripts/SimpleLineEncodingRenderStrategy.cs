using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using IVLab.Utilities.GenericObjectPool;


[EncodingStrategy("Ribbons",EncodingStrategyAttribute.DataType.Line)]
public class SimpleLineEncodingRenderStrategy : EncodingRenderStrategy
{


    //[ABRInput("Solid Color")]
    //public readonly IAssignable<Color> colorField = Color.white;
    [ABRInput("Width", "Width", "1%", "Width of the ribbons")]
    public readonly RealNumber thickness;

    [ABRInput("Average", "Average", "5", "Blend between the ends of ribbon textures", false)]
    public readonly RealNumber averageCount;

    [ABRInput("Color Variable", "Color")]
    public readonly IScalarDataVariable colorVariable;


    [ABRInput("Colormap", "Color", "White")]
    public readonly IColormap colormap;

    [ABRInput("Texture Variable", "Line Texture", "", "Variable to control which texture is used", true)]
    public readonly IScalarDataVariable lineTextureVariable;


    [ABRInput("Texture", "Line Texture", "None")]
    public readonly ILineTexture lineTexture;

    [ABRInput("Texture Cutoff", "Texture Cutoff", "50%", "how much of the light part of the texture to cut off")]
    public readonly RealNumber textureCutoff;

    [ABRInput("Ribbon Brightness", "Ribbon Brightness", "50%", "Brightness multiplier for ribbons")]
    public readonly RealNumber ribbonBrightness;

    [ABRInput("Ribbon Rotation", "Ribbon Rotation", "0", "Degrees to rotate the ribbons")]
    public readonly RealNumber ribbonRotationAngle;

    [ABRInput("Curve", "Curve", "0", "How much to curve the ribbons", true)]
    public readonly RealNumber ribbonCurveAngle;


    public class SimpleLineEncodingRenderInfo : EncodingRenderInfo, DataObjectRenderInfo
    {
        public Vector3[][] vertices;
        public int[][] indices;
        public Vector3[][] normals;
        public Color[][] scalars;
        public Vector2[][] uvs;

        public Vector4 scalarMin;
        public Vector4 scalarMax;
        public float meshScale;
    }



    MaterialPropertyBlock block;
    Material material;

    const string materialName = "ABR_DataTextureRibbon";

    public SimpleLineEncodingRenderStrategy() : base()
    {
        block = new MaterialPropertyBlock();
        material = Resources.Load<Material>(materialName);

    }

    public override DataObjectRenderInfo ComputeDataForDataObject(IDataObject dataObject)
    {
        
            return null;
    }

    public override EncodingRenderInfo ComputeEncodingDataForEncodedObject(EncodedObject encodedObject)
    {

        SimpleLineEncodingRenderInfo renderInfo;// = new SimpleLineEncodingRenderInfo();


        Dataset dataset = encodedObject?.Encoding?.dataObject?.dataset ;

        if (dataset == null || this.Hidden)
        {
            renderInfo = new SimpleLineEncodingRenderInfo
            {
                vertices = new Vector3[0][],
                indices = new int[0][],
                scalars = new Color[0][],
                normals = new Vector3[0][],
                uvs = new Vector2[0][],
                scalarMax = Vector4.zero,
                scalarMin = Vector4.zero
            };
        }
        else
        {

            float ribbonRotation = 0;
            float ribbonWidth = 0.01f;
            int averageCountN = 5;
            float curveAngle = 0.0f;
            if (ABRManager.IsValidNode(ribbonRotationAngle))
            {
                ribbonRotation = ribbonRotationAngle.floatVal*360;
            }
            if (ABRManager.IsValidNode(thickness))
            {
                ribbonWidth = thickness.floatVal;
            }
            if (ABRManager.IsValidNode(averageCount))
            {
                averageCountN = (int)(averageCount.floatVal);
            }
            if (ABRManager.IsValidNode(ribbonCurveAngle))
            {
                curveAngle = (int)(ribbonCurveAngle.floatVal);
            }
            ribbonWidth = ribbonWidth * encodedObject.dataScene.GetDataBounds().size.magnitude*0.5f;

        

            int numLines = 0;
            numLines = dataset.cellIndexCounts.Length;
            renderInfo = new SimpleLineEncodingRenderInfo
            {
                vertices = new Vector3[numLines][],
                indices = new int[numLines][],
                scalars = new Color[numLines][],
                normals = new Vector3[numLines][],
                uvs = new Vector2[numLines][],
                scalarMax = Vector4.zero,
                scalarMin = Vector4.zero
            };

            renderInfo.meshScale = 1;
            if (dataset.bounds.size.magnitude > 10000)
                renderInfo.meshScale /= 10000;

            int pointIndex = 0;

            float[] colorVariableArray = null;
            if (ABRManager.IsValidNode(colorVariable))
            {
                colorVariableArray = colorVariable.GetScalarArray(dataset);
                renderInfo.scalarMin[0] = colorVariable.GetScalarMin();
                renderInfo.scalarMax[0] = colorVariable.GetScalarMax();
            }

            for (int i = 0; i < numLines; i++)
            {
                Queue<Vector3> smoothingNormals = new Queue<Vector3>(averageCountN);
                Queue<Vector3> smoothingTangents = new Queue<Vector3>(averageCountN);

                int numPoints = dataset.cellIndexCounts[i];
                int numVerts = numPoints * 4;
                int numIndices = (numPoints - 1) * 12;
                renderInfo.vertices[i] = new Vector3[numVerts];
                renderInfo.normals[i] = new Vector3[numVerts];
                renderInfo.uvs[i] = new Vector2[numVerts];
                renderInfo.scalars[i] = new Color[numVerts];
                renderInfo.indices[i] = new int[numIndices];

                int indexOffset = dataset.cellIndexOffsets[i];

                int indexEnd = indexOffset + numPoints;

                float arclength = 0;

                Vector3 lastV = Vector3.up;
                for (int index = indexOffset, j = 0; index < indexEnd; index++, j++)
                {
                    pointIndex = dataset.indexArray[index];
                    var lastPointIndex = (j == 0) ? pointIndex : dataset.indexArray[index - 1];
                    var nextPointIndex = (j == numPoints - 1) ? pointIndex : dataset.indexArray[index + 1];

                    Vector3 point = dataset.vertexArray[pointIndex];
                    Vector3 lastPoint = dataset.vertexArray[lastPointIndex];
                    Vector3 nextPoint = dataset.vertexArray[nextPointIndex];

                    Vector3 tangent;
                    Vector3 normal;
                    Vector3 bitangent;
                    Vector3 fromLast = point - lastPoint;
                    Vector3 toNext = nextPoint - point;
                    Vector4 scalar = Vector4.zero;

                    arclength = arclength + fromLast.magnitude;
                    tangent = (fromLast + toNext).normalized;

                    Vector3 V = Vector3.Cross(fromLast.normalized, toNext.normalized).normalized;
                    if (Vector3.Dot(V, lastV) < 0) V = -V;
                    lastV = V;
                    Vector3 N = Vector3.Cross(V, tangent).normalized;
                    Vector3 normalSum = N;
                    Vector3 tangentDirSum = tangent.normalized;

                    if (smoothingNormals.Count > 0)
                    {
                        if (Vector3.Dot(smoothingNormals.Last(), N) < 0)
                            N = -N;
                        normalSum = N;

                        foreach (var n in smoothingNormals)
                        {
                            normalSum += n;
                        }
                        foreach (var t in smoothingTangents)
                        {
                            tangentDirSum += t.normalized;
                        }
                    }
                    Vector3 normalAvg = normalSum / (smoothingNormals.Count + 1);
                    Vector3 tangentAvg = tangentDirSum/ (smoothingNormals.Count + 1);


                    normal = normalAvg;
                    tangent = tangentAvg;

                    smoothingNormals.Enqueue(normal);
                    while (smoothingNormals.Count > averageCountN) smoothingNormals.Dequeue();
                    while (smoothingTangents.Count > averageCountN) smoothingTangents.Dequeue();


                    if (colorVariableArray != null)
                    {
                        scalar[0] = colorVariableArray[index];
                    }

                    normal = normal.normalized;
                    tangent = tangent.normalized;
                    bitangent = -Vector3.Cross(normal, tangent).normalized;



                    normal = Quaternion.AngleAxis(ribbonRotation, tangent) * normal;
                    bitangent = Quaternion.AngleAxis(ribbonRotation, tangent) * bitangent;


                    int indexTopFront = j * 4 + 0;
                    int indexTopBack = j * 4 + 1;
                    int indexBottomFront = j * 4 + 2;
                    int indexBottomBack = j * 4 + 3;

                    int nextIndexTopFront = (j + 1) * 4 + 0;
                    int nextIndexTopBack = (j + 1) * 4 + 1;
                    int nextIndexBottomFront = (j + 1) * 4 + 2;
                    int nextIndexBottomBack = (j + 1) * 4 + 3;

                    renderInfo.vertices[i][indexTopFront] = (point + bitangent * ribbonWidth + normal * ribbonWidth * 0.01f) * renderInfo.meshScale;
                    renderInfo.vertices[i][indexTopBack] = (point + bitangent * ribbonWidth - normal * ribbonWidth * 0.01f) * renderInfo.meshScale;
                    renderInfo.vertices[i][indexBottomFront] = (point - bitangent * ribbonWidth + normal * ribbonWidth * 0.01f) * renderInfo.meshScale;
                    renderInfo.vertices[i][indexBottomBack] = (point - bitangent * ribbonWidth - normal * ribbonWidth * 0.01f) * renderInfo.meshScale;

                    renderInfo.normals[i][indexTopFront] = Quaternion.AngleAxis(curveAngle, tangent) * normal;
                    renderInfo.normals[i][indexTopBack] = Quaternion.AngleAxis(-curveAngle, tangent) * -normal;
                    renderInfo.normals[i][indexBottomFront] = Quaternion.AngleAxis(-curveAngle, tangent) * normal;
                    renderInfo.normals[i][indexBottomBack] = Quaternion.AngleAxis(curveAngle, tangent) * -normal;

                    renderInfo.scalars[i][indexTopFront] = scalar;
                    renderInfo.scalars[i][indexTopBack] = scalar;
                    renderInfo.scalars[i][indexBottomFront] = scalar;
                    renderInfo.scalars[i][indexBottomBack] = scalar;



                    renderInfo.uvs[i][indexTopFront] = new Vector2(arclength/ (ribbonWidth*2), 0);
                    renderInfo.uvs[i][indexTopBack] = new Vector2(arclength/ (ribbonWidth*2), 0);
                    renderInfo.uvs[i][indexBottomFront] = new Vector2(arclength/ (ribbonWidth*2), 1);
                    renderInfo.uvs[i][indexBottomBack] = new Vector2(arclength/ (ribbonWidth*2), 1);



                    // threadData.colors[i][indexTopFront] = 
                    if (j < (numPoints - 10) && j > 1)
                    {
                        renderInfo.indices[i][j * 12 + 0] = indexTopFront;
                        renderInfo.indices[i][j * 12 + 1] = nextIndexTopFront;
                        renderInfo.indices[i][j * 12 + 2] = indexBottomFront;

                        renderInfo.indices[i][j * 12 + 3] = nextIndexTopFront;
                        renderInfo.indices[i][j * 12 + 4] = nextIndexBottomFront;
                        renderInfo.indices[i][j * 12 + 5] = indexBottomFront;

                        renderInfo.indices[i][j * 12 + 6] = indexBottomBack;
                        renderInfo.indices[i][j * 12 + 7] = nextIndexTopBack;
                        renderInfo.indices[i][j * 12 + 8] = indexTopBack;

                        renderInfo.indices[i][j * 12 + 9] = indexBottomBack;
                        renderInfo.indices[i][j * 12 + 10] = nextIndexBottomBack;
                        renderInfo.indices[i][j * 12 + 11] = nextIndexTopBack;
                    }

                }
            }
        }


        return renderInfo;
    }
    public override EncodedObject MakeEncodedGameObject(EncodedObject currentGameObject)
    {
        

        var lineResources = currentGameObject.encodingRenderInfo as SimpleLineEncodingRenderInfo;
        if (currentGameObject == null || lineResources == null)
        {
            //Debug.LogError("Something is wrong.");

            
            return currentGameObject;

        }
        int numLines = lineResources?.indices?.Length ?? 0;
        while (currentGameObject.transform.childCount < numLines)
        {
            GameObject renderObject = GenericObjectPool.Instance.GetObjectFromPool(this.GetType().Name + " meshRenderer", currentGameObject.transform, go => {
                go.name = "Line Render Object";
            });
            renderObject.transform.SetParent(currentGameObject.transform, false);
            renderObject.transform.localPosition = Vector3.zero;
            renderObject.transform.localScale = Vector3.one;
            renderObject.transform.localRotation = Quaternion.identity;
        }

        while(currentGameObject.transform.childCount > numLines)
        {
            GameObject child = currentGameObject.transform.GetChild(0).gameObject;
            GenericObjectPool.Instance.ReturnObjectToPool(child);
        }
        //if(SSrenderData == null || dataObject == null || currentGameObject == null)

        for (int i = 0; i < numLines; i++)
        {

            var renderObject = currentGameObject.transform.GetChild(i).gameObject;
            renderObject.layer = LayerMask.NameToLayer("Line");

            var meshFilter = renderObject.GetComponent<MeshFilter>();
            if (meshFilter == null)
                meshFilter = renderObject.AddComponent<MeshFilter>();

            var meshRenderer = renderObject.GetComponent<MeshRenderer>();
            if (meshRenderer == null)
                meshRenderer = renderObject.AddComponent<MeshRenderer>();

            meshRenderer.material = material;


            // SET MATERIAL STUFF



            // build mesh from dataset arrays
            Mesh mesh = renderObject.GetComponent<MeshFilter>().mesh;
            //if(mesh == null)
            //{
            mesh = meshFilter.mesh;
            if (mesh == null) mesh = new Mesh();
            mesh.name = "LRS:368@" + DateTime.Now.ToString();
            //}


            mesh.Clear();
            mesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;

            mesh.vertices = lineResources.vertices[i];
            mesh.normals = lineResources.normals[i];
            mesh.colors = lineResources.scalars[i];
            mesh.uv = lineResources.uvs[i];

            mesh.SetIndices(lineResources.indices[i], MeshTopology.Triangles, 0);

            mesh.UploadMeshData(false);


            meshFilter.mesh = mesh;

            meshRenderer.material = material;

            meshRenderer.GetPropertyBlock(block);
            block.SetColor("_Color", Color.white);
            if(ABRManager.IsValidNode(textureCutoff))
            {
                block.SetFloat("_TextureCutoff", textureCutoff.floatVal);
            } else
            {
                block.SetFloat("_TextureCutoff", 0.5f);

            }
            if(ABRManager.IsValidNode(ribbonBrightness))
            {
                block.SetFloat("_RibbonBrightness", ribbonBrightness.floatVal);
            } else
            {
                block.SetFloat("_RibbonBrightness", 0.5f);

            }
            if (ABRManager.IsValidNode(lineTexture))
            {
                block.SetTexture("_Texture", lineTexture.GetTexture());
                block.SetFloat("_TextureAspect", lineTexture.GetTexture().width /(float) lineTexture.GetTexture().height);
                block.SetInt("_UseLineTexture", 1);

            }
            else
            {
                block.SetInt("_UseLineTexture", 0);

            }
            block.SetFloat("_ColorDataMin", lineResources.scalarMin[0]);
            block.SetFloat("_ColorDataMax", lineResources.scalarMax[0]);
            if (colormap?.GetColorGradient() != null)
            {
                block.SetInt("_UseColorMap", 1);
                block.SetTexture("_ColorMap", colormap?.GetColorGradient());
            }
            else
            {
                block.SetInt("_UseColorMap", 0);
            }
            meshRenderer.SetPropertyBlock(block);


        }
        if (lineResources != null && lineResources.meshScale > 0) currentGameObject.transform.localScale = Vector3.one / lineResources.meshScale;

        return currentGameObject;
    }

    public override void RecycleEncodedGameObject(EncodedObject encodedObject)
    {
        GameObject go = encodedObject.gameObject;


        if (this.GetType().IsAssignableFrom(encodedObject.Encoding.renderingStrategy.GetType()) == false)
        {
            Debug.LogError("Encoded Object wasn't made with this render strategy");
            GameObject.Destroy(encodedObject);
            return;
        }

        while (go.transform.childCount > 0)
        {
            GameObject child = go.transform.GetChild(0).gameObject;
            GenericObjectPool.Instance.ReturnObjectToPool(child);
        }


        GenericObjectPool.Instance.ReturnObjectToPool(encodedObject.gameObject);

    }

    public override void ReceiveMessage(ABRUpdateMessage message)
    {
        base.ReceiveMessage(message);
    }


}
