using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerName : MonoBehaviour {


	public void LoadHome(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Menu);
	}


	/// <summary>
	/// Verifica que la caja no esté vacia, vguarda la varible y carga la escena de
	/// </summary>
	/// <param name="name">Name.</param>
	public void Next(Text name  ){		
		if (FUNCTIONS.VALIDATE_TEXT (name.text)) {
			PlayerPrefs.SetString (VARIABLES.PLAYERNAME_PREF, name.text);
			FUNCTIONS.LOAD_SCENE (VARIABLES.Nombre_Tienda);
		}

	}

}
