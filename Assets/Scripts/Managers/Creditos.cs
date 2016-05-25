using UnityEngine;
using System.Collections;

public class Creditos : MonoBehaviour {

	public GameObject groupFade; //Canvas Group que se isrá desvaneciendo cuando se complete el juego

	public void LoadHome(){
		PlayerPrefs.SetInt (VARIABLES.GAME_COMPLETE_PREF, 0);
		FUNCTIONS.LOAD_SCENE (VARIABLES.Menu);
	}

	void Start () {
		//PlayerPrefs.SetInt (VARIABLES.GAME_COMPLETE_PREF, 1);

		if (PlayerPrefs.GetInt (VARIABLES.GAME_COMPLETE_PREF) == 1) {
			groupFade.SetActive (true);
			StartCoroutine (fadeOut());
		}
	}

	IEnumerator fadeOut(){
		CanvasGroup canvasGroup= groupFade.GetComponent<CanvasGroup> ();
		yield return new WaitForSeconds(3.0f);
		while (canvasGroup.alpha > 0) {
			canvasGroup.alpha -= Time.deltaTime / 2;
			yield return null;
			//yield return new WaitForSeconds(0.2f);
		}
		groupFade.SetActive (false);
	}


		
}
