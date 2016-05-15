using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public AudioMixer sfx;

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

	public void SFXMusicVolume(Slider slide){
		float vol = slide.value;
		float dbVol;
		PlayerPrefs.SetFloat("SFXVol", vol);
		if (vol == 0) {
			dbVol = -80;
		} else {
			dbVol= -40+ (vol*40/100);
		}

		sfx.SetFloat ("SFXVolume", dbVol);
	}
}