using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelSelectManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		enableButtons ();
	}
	

	public void enableButtons(){
		int maxLevel = PlayerPrefs.GetInt (VARIABLES.PLAYERLEVEL);
		Button boton;
		Debug.Log (maxLevel);
		for(int l =1; l<=maxLevel;l++){
			boton = GameObject.Find ("Boton Nivel " + l).GetComponent<Button>();
			boton.interactable =true;
		}
	}


	public void LoadHome(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Menu);
	}

	public void LoadLevel(int level){
		PlayerPrefs.SetInt (VARIABLES.CURRENT_LEVEL, level);
		FUNCTIONS.LOAD_SCENE (VARIABLES.Dialogo);
	}

	public void LoadTutorial(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Tutorial_Dialogo);

	}

}
