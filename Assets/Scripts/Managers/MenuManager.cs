using UnityEngine;
using UnityEngine.Audio;
using System.Collections;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

	public AudioMixer sfx;

	/// <summary>
	/// Carga los vlores por defecto
	/// </summary>
	void Start () {
		SoundManager soundManager = gameObject.GetComponent<SoundManager> ();
		soundManager.LoadValues ();
		PlayerPrefs.SetInt (VARIABLES.GAME_COMPLETE_PREF, 0);
	}
	

	/// <summary>
	/// Carga un nuevo juego y reinicia las variables de niveles
	/// </summary>
	public void NewGame(){
		PlayerPrefs.SetInt ( VARIABLES.PLAYERLEVEL, 1);
		FUNCTIONS.LOAD_SCENE (VARIABLES.Nombre_Jugador);
	}

	/// <summary>
	/// Carga la escena de niveles para que continúen con el juego
	/// </summary>
	public void ContinueGame(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Niveles);
	}

	public void cargaCreditos(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Creditos);
	}

	public void LoadTutorial(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Tutorial);

	}
}