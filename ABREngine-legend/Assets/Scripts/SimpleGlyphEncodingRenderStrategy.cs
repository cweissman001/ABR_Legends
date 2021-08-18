using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using UnityEngine;
using IVLab.Utilities.GenericObjectPool;


[EncodingStrategy("Glyphs",EncodingStrategyAttribute.DataType.Point)]
public class SimpleGlyphEncodingRenderStrategy : EncodingRenderStrategy
{


    //[ABRInput("Solid Color")]
    //public readonly IAssignable<Color> colorField = Color.white;
    [ABRInput("Glyph Size", "Glyph Size","5%", "Percentage of the visualization size")]
    public readonly RealNumber glyphSize;

    [ABRInput("Glyph Simplification", "Glyph Simplification","1","Degree of mesh simplification using LODs, 0 is most complex",advancedOnly = true)]
    public readonly RealNumber glyphLod;

    [ABRInput("Color Variable", "Color")]
    public readonly IScalarDataVariable colorVariable;


    [ABRInput("Colormap", "Color", "White", "If no variable is selected, the middle of the colormap will be used")]
    public readonly IColormap colormap;

    [ABRInput("Glyph", "Glyph", "Sphere")]
    public readonly IGlyph glyph;

    [ABRInput("Glyph Variable", "Glyph", advancedOnly = true)]
    public readonly IScalarDataVariable glyphVariable;


    [ABRInput("Forward Direction", "Forward Direction", "Random", "Vector for aligning the forward direction of each glyph")]
    public readonly IVectorDataVariable forwardVariable;

    [ABRInput("Up Direction", "Up Direction", "Random", "Vector for aligning the top of each glyph")]
    public readonly IVectorDataVariable upVariable;

    public class SimpleGlyphDataObjectRenderInfo : DataObjectRenderInfo
    {
        public Vector3[] positions;
        public Quaternion[] orientations;
        public Vector4[] scalars;
        public float colorVariableMin;
        public float colorVariableMax;
        public Bounds bounds;

    }

    public class SimpleGlypEncodingRenderInfo : EncodingRenderInfo
    {
        public Matrix4x4[] transforms;
        public Vector4[] scalars;
        public float colorVariableMin;
        public float colorVariableMax;
        public Bounds bounds;
    }



    MaterialPropertyBlock block;
    Material material;

    const string materialName = "ABR_DataGlyphs"; 
    
    public SimpleGlyphEncodingRenderStrategy() : base()
    {
        block = new MaterialPropertyBlock();
        material = Resources.Load<Material>(materialName);

    }

    public override DataObjectRenderInfo ComputeDataForDataObject(IDataObject dataObject)
    {
        SimpleGlyphDataObjectRenderInfo renderInfo;
        Dataset dataset = dataObject?.dataset;
        if (dataset == null || this.Hidden)
        {
            renderInfo = new SimpleGlyphDataObjectRenderInfo
            {
                positions = new Vector3[0],
                orientations = new Quaternion[0],
                scalars = new Vector4[0],
                colorVariableMin = 0,
                colorVariableMax = 0
            };
        } else
        {
            float colorMin, colorMax;
            colorMin = colorVariable?.GetScalarMin() ?? 0.0f;
            colorMax = colorVariable?.GetScalarMax() ?? 0.0f;
            int numPoints = dataset.vertexArray.Length;
            renderInfo = new SimpleGlyphDataObjectRenderInfo
            {
                positions = new Vector3[numPoints],
                orientations = new Quaternion[numPoints],
                scalars = new Vector4[numPoints],
                colorVariableMin = colorMin,
                colorVariableMax = colorMax
            };
            for(int i = 0; i < numPoints; i++)
            {
                renderInfo.positions[i] = dataset.vertexArray[i];
            }

            if (ABRManager.IsValidNode(colorVariable))
            {
                var colorScalars = colorVariable.GetScalarArray(dataset);
                for (int i = 0; i < numPoints; i++)
                    renderInfo.scalars[i][0] = colorScalars[i];

            }
            else {} // Leave the scalars as 0

            Vector3[] dataForwards = null;
            Vector3[] dataUp = null;

            if (ABRManager.IsValidNode(forwardVariable))
            {
                dataForwards = forwardVariable.GetVectorArray(dataset);
            } else
            {
                var rand = new System.Random(0);
                dataForwards = new Vector3[numPoints];
                for (int i = 0; i < numPoints; i++)
                {
                    dataForwards[i] = new Vector3(
                        (float)rand.NextDouble() * 2 - 1,
                        (float)rand.NextDouble() * 2 - 1,
                        (float)rand.NextDouble() * 2 - 1);
                }
            }

            if (ABRManager.IsValidNode(upVariable))
            {
                dataUp = upVariable.GetVectorArray(dataset);
            }
            else
            {
                var rand = new System.Random(1);
                dataUp = new Vector3[numPoints];
                for (int i = 0; i < numPoints; i++)
                {
                    dataUp[i] = new Vector3(
                        (float)rand.NextDouble() * 2 - 1,
                        (float)rand.NextDouble() * 2 - 1,
                        (float)rand.NextDouble() * 2 - 1);
                }
            }

            if (ABRManager.IsValidNode(upVariable) && !ABRManager.IsValidNode(forwardVariable))
            { // Treat up as the more rigid constraint
                for (int i = 0; i < numPoints; i++)
                {
                    Vector3 rightAngleForward = Vector3.Cross(
                    Vector3.Cross(dataUp[i], dataForwards[i]).normalized,
                    dataUp[i]).normalized;

                    Quaternion orientation = Quaternion.LookRotation(rightAngleForward, dataUp[i]) * Quaternion.Euler(0, 180, 0);
                    renderInfo.orientations[i] = orientation;
                }
            }
            else // Treat forward as the more rigid constraint
            {
                for (int i = 0; i < numPoints; i++)
                {

                    Vector3 rightAngleUp = Vector3.Cross(
                        Vector3.Cross(dataForwards[i], dataUp[i]).normalized,
                        dataForwards[i]).normalized;

                    Quaternion orientation = Quaternion.LookRotation(dataForwards[i], rightAngleUp) * Quaternion.Euler(0, 180, 0);
                    renderInfo.orientations[i] = orientation;
                }
            }
            

        }
        renderInfo.bounds = dataset?.bounds ?? new Bounds();

        return renderInfo;
    }

    public override EncodingRenderInfo ComputeEncodingDataForEncodedObject(EncodedObject encodedObject)
    {

        var dataRenderInfo = (SimpleGlyphDataObjectRenderInfo)encodedObject.Encoding.dataObjectRenderInfo;

        int numPoints = dataRenderInfo.scalars.Length;

        var encodingRenderInfo = new SimpleGlypEncodingRenderInfo()
        {
            transforms = new Matrix4x4[numPoints],
            scalars = dataRenderInfo.scalars,
            colorVariableMin = dataRenderInfo.colorVariableMin,
            colorVariableMax = dataRenderInfo.colorVariableMax
        };


  
        float glyphScaleFraction = 0.05f;
        if(ABRManager.IsValidNode(glyphSize))
        {
            glyphScaleFraction = glyphSize.floatVal;
        }

        float sceneScale = encodedObject.dataScene.GetDataBounds().size.magnitude;


        float glyphScale = sceneScale * glyphScaleFraction;


        for (int i = 0; i < numPoints; i++)
        {

            encodingRenderInfo.transforms[i] = Matrix4x4.TRS(dataRenderInfo.positions[i], dataRenderInfo.orientations[i], Vector3.one * glyphScale);

        }
        encodingRenderInfo.bounds = dataRenderInfo.bounds;
        return encodingRenderInfo;
    }
    public override EncodedObject MakeEncodedGameObject(EncodedObject currentGameObject)
    {

        //if (renderData == null) return currentGameObject;

        var SSrenderData = currentGameObject.encodingRenderInfo as SimpleGlypEncodingRenderInfo;
        if(/*SSrenderData == null || dataObject == null ||*/ currentGameObject == null)
        {
            Debug.LogError("Something is wrong.");
            return currentGameObject;
        }


        
        currentGameObject.gameObject.layer = LayerMask.NameToLayer("Glyph");
        MeshRenderer mr = currentGameObject.GetComponent<MeshRenderer>();
        if (mr == null)
        {
            mr = currentGameObject.gameObject.AddComponent<MeshRenderer>();
        }



        if (ABRManager.IsValidNode(colormap))
        {
            block.SetInt("_UseColorMap", 1);
            block.SetTexture("_ColorMap", colormap.GetColorGradient());
        }
        else
        {
            block.SetInt("_UseColorMap", 0);

        }



        InstancedMeshRenderer imr = currentGameObject.GetComponent<InstancedMeshRenderer>();
        if (imr == null)
        {
            imr = currentGameObject.gameObject.AddComponent<InstancedMeshRenderer>();
        }
        imr.bounds = SSrenderData?.bounds ?? new Bounds();

        int lod = 1;
        if (ABRManager.IsValidNode(glyphLod))
        {
            lod = (int)glyphLod.floatVal;
        }
        if (ABRManager.IsValidNode(glyph))
        {

            imr.instanceMesh = glyph.GetMesh(lod);
            block.SetTexture("_Normal", glyph.GetNormalMap(lod));
            //block.SetTexture("_NormalMap",glyph.GetNormalMap());
        }
        else
        {
            imr.instanceMesh = VisAssetManager.GetDefaultGlyphMesh();
            block.SetTexture("_Normal", VisAssetManager.GetDefaultNormal());


        }



        if (SSrenderData != null)
        {
            block.SetFloat("_ColorDataMin", SSrenderData.colorVariableMin);
            block.SetFloat("_ColorDataMax", SSrenderData.colorVariableMax);
            block.SetColor("_Color", Color.white);

            imr.instanceLocalTransforms = SSrenderData.transforms;
            imr.colors = SSrenderData.scalars;
            if (colormap?.GetColorGradient() != null)
            {
                block.SetInt("_UseColorMap", 1);
                block.SetTexture("_ColorMap", colormap?.GetColorGradient());
            }
            else
            {
                block.SetInt("_UseColorMap", 0);
            }
        }
        else
        {
            imr.instanceLocalTransforms = new Matrix4x4[0];

        }

        imr.block = block;

        imr.instanceMaterial = material;

        imr.cachedInstanceCount = -1;



        //MeshFilter meshFilter;
        //MeshRenderer meshRenderer;

        //meshFilter = currentGameObject.GetComponent<MeshFilter>();
        //meshRenderer = currentGameObject.GetComponent<MeshRenderer>();

        //if (meshFilter == null)
        //{
        //    meshFilter = currentGameObject.gameObject.AddComponent<MeshFilter>();

        //}
        //if(meshRenderer == null)
        //{
        //    meshRenderer = currentGameObject.gameObject.AddComponent<MeshRenderer>();
        //}

        //currentGameObject.name = this + " surface Mesh";



        //Mesh mesh = new Mesh();
        //mesh.indexFormat = UnityEngine.Rendering.IndexFormat.UInt32;
        //mesh.vertices = SSrenderData.meshVertices;
        //mesh.normals = SSrenderData.meshNormals;
        //mesh.colors = SSrenderData.meshColors;
        //mesh.SetIndices(SSrenderData.meshIndices, dataObject.dataset.meshTopology, 0);
        //mesh.UploadMeshData(false);
        //meshFilter.mesh = mesh;

        //meshRenderer.material = material;

        //meshRenderer.GetPropertyBlock(block);
        //block.SetColor("_Color", colorField?.value ?? Color.black);
        //block.SetFloat("_ColorDataMin", SSrenderData.colorVariableMin);
        //block.SetFloat("_ColorDataMax", SSrenderData.colorVariableMax);
        //if (colormap?.GetColorGradient() != null)
        //{
        //    block.SetInt("_UseColorMap", 1);
        //    block.SetTexture("_ColorMap", colormap?.GetColorGradient());
        //}
        //else
        //{
        //    block.SetInt("_UseColorMap", 0);
        //}
        //meshRenderer.SetPropertyBlock(block);


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
