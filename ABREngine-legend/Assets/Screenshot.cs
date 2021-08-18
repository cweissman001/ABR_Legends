using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


public class Screenshot : MonoBehaviour
{

    public string filePath;
    public bool takeScreenshot = false;

    public void Capture(string filepath, int width, int height, bool transparentBackground = true)
    {
        var camera = GetComponent<Camera>();
        RenderTexture rt = new RenderTexture(width, height, 24);
        Color temp = camera.backgroundColor;
        if(transparentBackground == true)
        {
            camera.backgroundColor = Color.clear;
        }
        camera.targetTexture = rt;
        Texture2D image = new Texture2D(width, height, TextureFormat.RGB24, false);
        camera.Render();


        RenderTexture.active = rt;
        image.ReadPixels(new Rect(0, 0, camera.pixelWidth, camera.pixelHeight), 0, 0);
        image.Apply();

        camera.targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);

        byte[] bytes = image.EncodeToPNG();
        if (File.Exists(filepath))
        {
            File.WriteAllBytes(filepath, bytes);
        }
        else
        {
            File.WriteAllBytes(filepath, bytes);
        }

        //Debug.Log(string.Format("Took screenshot to: {0}", filepath));

        //Debug.Log("Capture!!");
        camera.backgroundColor = temp;

        RenderTexture.active = null;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void LateUpdate()
    {
        if (takeScreenshot)
        {
            takeScreenshot = false;
            Capture(filePath, 1920, 1080, true);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
