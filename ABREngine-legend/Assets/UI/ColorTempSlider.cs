using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ColorTempSlider : MonoBehaviour {
	public Light l;
	private float t = 6500; // temp variable, set to default white=6500

	public UnityEngine.UI.Slider slider;

	// Use this for initialization
	void Start () {
		l = GetComponent<Light> ();
		GraphicsSettings.lightsUseLinearIntensity = true;
		GraphicsSettings.lightsUseColorTemperature = true;
		l.useColorTemperature = true;
	}
	
	// Update is called once per frame
	void Update () {
		// followed settings in unity found here to get colorTemp mode on
		// https://kpprt.de/tutorial/enable-color-temperature-mode-in-unity/

		// should be able to use these lines to make the changes non-manually
		// but they are not compiling (version issue?)

//		GraphicsSettings.lightsUseLinearIntensity = true;
//		GraphicsSettings.lightsUseColorTemperature = true;

		if(slider.value != l.colorTemperature)
		{
			slider.value = l.colorTemperature;
		}
	}


	public void SetTemperature(float temp)
	{
		t = temp;
		l.colorTemperature = t;

	}

	/*void OnGUI() {
		// based on range of color temp from link above
		t = GUI.HorizontalSlider (new Rect (10, 45, 150, 100), t, 1000, 12000);
		l.colorTemperature = t;
		GUI.Label(new Rect(40,55,125,100), "Light Temperature");

	}*/
}
