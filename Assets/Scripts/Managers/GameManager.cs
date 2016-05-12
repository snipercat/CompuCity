using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NewGame(){
		PlayerPrefs.SetInt ("PlayerLevel", 1);
		CargarEscena cargar = gameObject.GetComponent<CargarEscena> ();
		cargar.Cargar ("2.1. Nombre Jugador");
	}

	public void BGMusicVolume(Slider slide){
		BGMusic bgmusic = GameObject.Find ("BGMusic").GetComponent<BGMusic> ();
		bgmusic.BGMusicVolume (slide.value);
	}
}