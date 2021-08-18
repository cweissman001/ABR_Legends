using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVisAsset : IAssignable { }

public interface IColormap : IAssignable, IUIVisAssetInput
{
    Color GetColorInterp(float interpAmount);
    Texture2D GetColorGradient();

}
public interface ISurfaceTexture : IAssignable, IUIVisAssetInput
{
    Texture2D [] GetTextureList();
    Texture2D [] GetTextureNormalMapList();

    Texture2D GetTexture();
    Texture2D GetTextureNormalMap();



}

public interface ILineTexture : IAssignable, IUIVisAssetInput
{
    Texture2D GetTexture();
}


public interface IGlyph : IAssignable, IUIVisAssetInput
{
    Mesh GetMesh(int lod = 0);

    Texture2D GetNormalMap(int lod = 0);
}
public interface IUnsavable
{

}

public class SurfaceTextureVisAsset : ABRObject, ISurfaceTexture, IVisAsset
{
    public Texture2D[] TextureArray { get; set; } = null;

    public Texture2D [] NormalMapArray { get; set; } = null;

    public Texture2D[] GetTextureList()
    {
        return TextureArray;
    }
    public Texture2D[] GetTextureNormalMapList()
    {
        return NormalMapArray;
    }

    public Texture2D GetTexture()
    {
        if(TextureArray != null && TextureArray.Length > 0)
        {
            return TextureArray[0];
        } else return null;
    }

    public Texture2D GetTextureNormalMap()
    {
        if (NormalMapArray != null && NormalMapArray.Length > 0)
        {
            return NormalMapArray[0];
        }
        else return null;
    }
}

public class LineTextureVisAsset : ABRObject, ILineTexture, IVisAsset
{
    public Texture2D[] TextureArray { get; set; } = null;


    public Texture2D[] GetTextureList()
    {
        return TextureArray;
    }

    public Texture2D GetTexture()
    {
        if (TextureArray != null && TextureArray.Length > 0)
        {
            return TextureArray[0];
        }
        else return null;
    }


}


public class GlyphVisAsset : ABRObject, IGlyph, IVisAsset
{
    public List<Mesh> MeshLods { get; set; } = new List<Mesh>();

    public List<Texture2D> NormalMapLods { get; set; } = new List<Texture2D>();

    public Mesh GetMesh(int lod = 0)
    {
        return MeshLods[lod];
    }

    public Texture2D GetNormalMap(int lod = 0)
    {
        return NormalMapLods[lod];
    }
}

public class AliasColormapVisAsset : AliasAssignable<IColormap>, IColormap
{

    public Color GetColorInterp(float interpAmount)
    {
        return GetTargetNode()?.GetColorInterp(interpAmount) ?? default;
    }

    public Texture2D GetColorGradient()
    {
        return GetTargetNode()?.GetColorGradient() ?? default;
    }
}

public class TextureColormapVisAsset : ABRObject, IColormap, IVisAsset
{
    public Texture2D Gradient { get; set; } = null;

    public Color GetColorInterp(float interpAmount)
    {
        return Gradient.GetPixelBilinear(interpAmount, 0.5f);
    }

    public Texture2D GetColorGradient()
    {
        return Gradient;
    }

}
