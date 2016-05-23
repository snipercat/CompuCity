using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public static class FUNCTIONS{
	
	public static bool VALIDATE_TEXT(string variable){
		if (variable.Length>0) {
			return true;
		}
		return false;
	}

	public static void LOAD_SCENE(string escena){
			SceneManager.LoadScene(escena);
	}
}
