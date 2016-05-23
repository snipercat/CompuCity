using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour {

	public AudioMixer sfx;
	public AudioMixer BGMusic;

	/// <summary>
	/// Carga el valor por defecto del volumen de Música de fondo y de SFX.
	/// </summary>
	public void LoadValues(){
		SFXMusicVolume (PlayerPrefs.GetFloat (VARIABLES.SFXPlayerPref));
		BGMusicVolume (PlayerPrefs.GetFloat (VARIABLES.BGPlayerPref));
	}
	


	/// <summary>
	/// Define el valor del volumen de SFX de acuerdo al Slider
	/// </summary>
	/// <param name="slide">Slide.</param>
	public void SFXMusicVolume(Slider slide){
		float vol = slide.value;
		SFXMusicVolume (vol);
	}

	/// <summary>
	/// Define el volumen de SFX.
	/// </summary>
	/// <param name="vol">Vol.</param>
	public void SFXMusicVolume(float vol){
		float dbVol;
		PlayerPrefs.SetFloat(VARIABLES.SFXPlayerPref, vol);
		if (vol == 0) {
			dbVol = -80;
		} else {
			dbVol= -40+ (vol*40/100);
		}

		sfx.SetFloat (VARIABLES.SFXAudioMixer, dbVol);
	}


	/// <summary>
	/// Define el valor del volumen de múica de fondo de acuerdo al Slider
	/// </summary>
	/// <param name="slide">Slide.</param>
	public void BGMusicVolume(Slider slide){
		float vol = slide.value;
		BGMusicVolume (vol);
	}


	/// <summary>
	/// Define el valor de la música de fondo
	/// </summary>
	/// <param name="vol">Vol.</param>
	public void BGMusicVolume(float vol){
		float dbVol;
		PlayerPrefs.SetFloat(VARIABLES.BGPlayerPref, vol);
		if (vol == 0) {
			dbVol = -80;
		} else {
			dbVol= -40+ (vol*40/100);
		}

		BGMusic.SetFloat (VARIABLES.BGAudioMixer, dbVol);
	}


}
