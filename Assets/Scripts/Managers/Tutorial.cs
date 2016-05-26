using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {

	public GameObject[] imagenes;
	public GameObject nextButton;

	private int im=0;



	public void next(){
			imagenes[im].SetActive(false);
			im++;
		if (im == imagenes.Length) {
			nextButton.SetActive (false);
		}
	}

	public void goHome(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Menu);
	}

}
