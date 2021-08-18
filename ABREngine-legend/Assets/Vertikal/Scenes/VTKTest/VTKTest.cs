using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using VTK;

public class VTKTest : MonoBehaviour {
    public Text versionText;
    public Text dataText;

	// Use this for initialization
	void Start () {
        print("Using VTK version " + vtkVersion.GetVTKVersion());		
	    if(versionText != null)
            versionText.text = "Using VTK version " + vtkVersion.GetVTKVersion();

        vtkXMLImageDataReader imageDataReader = vtkXMLImageDataReader.New();
        imageDataReader.SetFileName(Application.streamingAssetsPath + "/test.vti");
        imageDataReader.Update();
        vtkDataSet dataSet = imageDataReader.GetOutputAsDataSet();
        string dataReport = "Test Data is of type " + dataSet.GetClassName() + " and has " + dataSet.GetNumberOfPoints() + " points.";
        print(dataReport);
        print(dataSet.GetPoint(0));
        

        if (dataText != null)
            dataText.text = dataReport;


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
