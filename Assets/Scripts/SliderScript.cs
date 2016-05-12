using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour {

	//El Slider cargará su valor por defecto de acuerdo a esta variable
	public string Defvariable = "none";
	// Use this for initialization

	void Start () {
		if (Defvariable != "none")
			ValueFromVariable (Defvariable);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ValueFromVariable(string variable){
		Slider slide = gameObject.GetComponent<Slider>();
		slide.value = PlayerPrefs.GetFloat (variable);
	}
}
