using MarchingBytes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;
using UnityEngine;





public class Debugger : MonoBehaviour
{
    ABRNode testNode = null;
    bool CanAssign(object value, System.Type inputType)
    {
        //return value.GetType().IsAssignableFrom(inputType);
        return inputType.IsAssignableFrom(value.GetType());
    }

    public bool buildState = false;
    // Start is called before the first frame update
    void BuildState()
    {
      /*  ABRManager.Instance.ClearState();

















        SimpleSurfaceEncodingRenderStrategy simpleSurfaceEncodingYellow = ABRManager.CreateNode<SimpleSurfaceEncodingRenderStrategy>();
        SimpleSurfaceEncodingRenderStrategy simpleSurfaceEncodingBlue = ABRManager.CreateNode<SimpleSurfaceEncodingRenderStrategy>();
        SimpleGlyphEncodingRenderStrategy simpleGlyphEncoding = ABRManager.CreateNode<SimpleGlyphEncodingRenderStrategy>();


        testNode = simpleSurfaceEncodingBlue;

        RealNumber realNumber = ABRManager.CreateNode<RealNumber>();

        realNumber._val = 42;


        ColorSource colorSourceBlue = ABRManager.CreateNode<ColorSource>(Color.blue);
        ColorSource colorSourceYellow = ABRManager.CreateNode<ColorSource>(Color.yellow);
        testNode = colorSourceYellow;

        ABRManager.Instance.SetNodeLabel(colorSourceBlue, "colorRed", true);




        //simpleSurfaceEncodingYellow.AssignInput(0, colorSourceYellow);
        //simpleSurfaceEncodingBlue.AssignInput(0, colorSourceBlue);




        ABRDataScene dataScene = ABRManager.CreateNode<ABRDataScene>();












        //RawScalarDataVariable scalar = ABRManager.CreateNode<RawScalarDataVariable>();
        //ABRManager.Instance.SetNodeLabel(scalar, "Result");


        IDataObject dataObjectSurface = ABRManager.CreateNode<DataObject>();
        IDataObject dataObjectSlice = ABRManager.CreateNode<DataObject>();
        IDataObject dataObjectPoints = ABRManager.CreateNode<DataObject>();



        ABRManager.Instance.SetNodeLabel(dataObjectSlice, "slice");
        ABRManager.Instance.SetNodeLabel(dataObjectSurface, "surface");
        ABRManager.Instance.SetNodeLabel(dataObjectPoints, "points");


        ABRManager.Instance.AssignInputFromLabel(simpleSurfaceEncodingYellow, "Color Variable", "RTDataGradientMag");

        ABRManager.Instance.AssignInputFromLabel(simpleSurfaceEncodingBlue, "Color Variable", "RTDataGradientMag");






        EncodingSet encodingSet = ABRManager.CreateNode<EncodingSet>();
        ABREncoding encodingSlice = ABRManager.CreateNode<ABREncoding>();
        ABREncoding encodingSurface = ABRManager.CreateNode<ABREncoding>();
        ABREncoding encodingPoints = ABRManager.CreateNode<ABREncoding>();

        ABRManager.Instance.SetNodeLabel(encodingSet, "Test Encoding Set", true);

        encodingSet.Add(encodingSlice);

        encodingSlice.AssignInput("Data Object", dataObjectSlice);
        encodingSlice.AssignInput("Rendering Strategy", simpleSurfaceEncodingYellow);


        encodingSet.Add(encodingSurface);

        encodingSurface.AssignInput("Data Object", dataObjectSurface);
        encodingSurface.AssignInput("Rendering Strategy", simpleSurfaceEncodingBlue);

        encodingSet.Add(encodingPoints);

        encodingPoints.AssignInput("Data Object", dataObjectPoints);
        encodingPoints.AssignInput("Rendering Strategy", simpleGlyphEncoding);


        visassetMappings = ABRManager.CreateNode<ABRLabelAliasMapper<IColormapVisAsset>>();

        visassetMappings.AddMapping("foo", "yellow orange colormap");
        visassetMappings.AddMapping("foo2", "blue colormap");





        ABRManager.Instance.SetNodeLabel(colorSourceBlue, "My Color", true);

        dataScene.AssignInput("Encoding Set", encodingSet);



        AliasColormapVisAsset colormapAlias = ABRManager.CreateNode<AliasColormapVisAsset>();
        colormapAlias.AliasLabel = "foo";

        AliasColormapVisAsset colormapAlias2 = ABRManager.CreateNode<AliasColormapVisAsset>();
        colormapAlias2.AliasLabel = "foo2";


        colormapAlias.AssignInput(0, visassetMappings);
        colormapAlias2.AssignInput(0, visassetMappings);

        ABRLabelAliasMapper<IScalarDataVariable> scalarMapper = ABRManager.CreateNode<ABRLabelAliasMapper<IScalarDataVariable>>() ;



        ABRManager.Instance.SetNodeLabel(scalarMapper, "Scalar Mapper");
        scalarMapper.AddMapping("bar", "RTDataGradientMag");

        AliasScalarDataVariable aliasScalar = ABRManager.CreateNode<AliasScalarDataVariable>();
        aliasScalar.AliasLabel = "bar";
        aliasScalar.AssignInput(0, scalarMapper);

        //simpleSurfaceEncodingYellow.AssignInput("Color Variable", aliasScalar);
        ABRManager.Instance.AssignInputFromLabel(simpleSurfaceEncodingYellow, "Color Variable", "ScalarVariable: RTDataGradientMag");
        //simpleSurfaceEncodingBlue.AssignInput("Color Variable", aliasScalar);
        ABRManager.Instance.AssignInputFromLabel(simpleSurfaceEncodingBlue, "Color Variable", "ScalarVariable: RTDataGradientMag");

        simpleSurfaceEncodingYellow.AssignInput("Colormap", colormapAlias);
        simpleSurfaceEncodingBlue.AssignInput("Colormap", colormapAlias2);


        ABRManager.Instance.AssignInputFromGuid(simpleGlyphEncoding, "Glyph", new Guid("5da5a87c-bace-4780-886b-ca92ef327363"));

        simpleGlyphEncoding.AssignInput("Colormap", colormapAlias2);




        //ABRDataScene dataScene2 = ABRManager.CreateNode<ABRDataScene>();


        //dataScene2.AssignInput("Encoding Set", encodingSet);

        testNode = encodingSet;


    */

    }
    //ABRLabelAliasMapper<IColormapVisAsset> visassetMappings;



    public string details = "";
    public bool DoThing = false;

    // Update is called once per frame
    void Update()
    {
        if(buildState == true)
        {
            buildState = false;

            BuildState();
        }
        //details = (ABRManager.Instance.FindNodeForLabel<IAliasMapper<IScalarDataVariable>>("Scalar Mapper").GetMappedNode("bar") == null) ? "null" : "not null";
    }
}
