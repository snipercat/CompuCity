using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

/// <summary>
/// Carga una escena automáticamente despues de u tmpo
/// </summary>
public class CargarEscena : MonoBehaviour {

	public string Escena;
	public float time = 0;


	// Use this for initialization
	void Start () {
			StartCoroutine (WaitToLoad ());	
	}


	IEnumerator WaitToLoad(){
		//animation.CrossFade("Death"); // smoothly start the Death animation
		yield return new WaitForSeconds(time); // wait time enough
		FUNCTIONS.LOAD_SCENE(Escena);
	}


}
