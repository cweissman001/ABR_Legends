using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingIntensitySlider : MonoBehaviour {
	// initalization
	public Light l;
	private float i = 1.0f;
	public UnityEngine.UI.Slider slider;

	void Start () {
		l = GetComponent<Light> (); 

	}
	
	// Update is called once per frame
	void Update () {
		if (slider.value != l.intensity)
		{
			slider.value = l.intensity;
		}
	}
	public void SetIntensity(float intensity)
	{
		i = intensity;
		l.intensity = i;
	}
	/*void OnGUI () {
		// value of light intensity is between 0 and 8
		i = GUI.HorizontalSlider (new Rect (10, 10, 150, 100), i, 0.0f, 8.0f);
		l.intensity = i;
		// label slider
		GUI.Label(new Rect(20,20,125,100), "Light Intensity");
	}*/
}
