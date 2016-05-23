using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {


	// /// <summary>
	/// Al inicializar se carga el valor guardado del volumen de la música
	/// Y da la orden para que no se destruya el objeto cuando se cambia de escena.
	/// </summary>
	void Start () {
		DontDestroyOnLoad (gameObject);
	
		//Si no existe la variable de Volumen, se crea y se define con valor de 75.
		if(!PlayerPrefs.HasKey("BGMusicVol") )
			PlayerPrefs.SetFloat("BGMusicVol", 75);

		//Define el volumen de la música
		BGMusicVolume (PlayerPrefs.GetFloat("BGMusicVol"));
	}



	/// <summary>
	/// Define el volumen de la música, 
	/// </summary>
	/// <param name="vol">Vol.</param>
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
