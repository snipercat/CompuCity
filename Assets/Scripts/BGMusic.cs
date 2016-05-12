using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {


	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
	
		//Si no existe la variable de Volumen, se crea y se define con valor de 75.
		if(!PlayerPrefs.HasKey("BGMusicVol") )
			PlayerPrefs.SetFloat("BGMusicVol", 75);

		//Define el volumen de la música
		BGMusicVolume (PlayerPrefs.GetFloat("BGMusicVol"));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	/*public void BGMusicEnable(){
		AudioSource BGMusic =  gameObject.GetComponent<AudioSource>();
		PlayerPrefs.SetInt("BGMusic", 1);
		if (BGMusic.isPlaying) {
			BGMusic.Stop ();
			PlayerPrefs.SetInt("BGMusic", 0);
		} else {
			BGMusic.Play ();
			PlayerPrefs.SetInt("BGMusic", 1);
		}
	}*/

	public void BGMusicVolume(float vol){
		float dbVol;
		PlayerPrefs.SetFloat("BGMusicVol", vol);
		if (vol == 0) {
			dbVol = -80;
		} else {
			dbVol= -40+ (vol*40/100);
		}

		AudioSource BGMusic =  gameObject.GetComponent<AudioSource>();
		BGMusic.outputAudioMixerGroup.audioMixer.SetFloat ("BGVolume", dbVol);
	}
}
