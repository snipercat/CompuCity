using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSelectManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		enableButtons ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void enableButtons(){
		int maxLevel = PlayerPrefs.GetInt ("PlayerLevel");
		Button boton;
		Debug.Log (maxLevel);
		for(int l =1; l<=maxLevel;l++){
			boton = GameObject.Find ("Boton Nivel " + l).GetComponent<Button>();
			boton.interactable =true;
		}
	}

	public void LoadLevel(int level){
		PlayerPrefs.SetInt ("Level", level);
		CargarEscena cargar = gameObject.GetComponent<CargarEscena> ();
		cargar.Cargar ("4.1. Nivel 1.1");
	}
}
