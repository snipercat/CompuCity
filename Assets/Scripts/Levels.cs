using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Levels : MonoBehaviour {
	private int[,] l1_secuece;
	private string[,] l1_message;

	private string[] buttons = new string[]{"","destornillador","antivirus","cargador"};

	private int[,] secuece;
	private string[,] message;
	private int state = 0;

	// Use this for initialization
	void Start () {
		int level = PlayerPrefs.GetInt ("Level");
		if (level == 1) {
			secuece = l1_secuece;
			message = l1_message;
		}
		blockButtons ();
	
	}

	private void blockButtons(){
		Button boton;
		for (int c = 1; c < buttons.GetLength(0); c++) {
			boton = GameObject.Find (buttons[c]).GetComponent<Button>();
			boton.interactable = secuece[state,c] == 1;
		}
	}

	public void check(int buttonId, Text dialog){
		if (secuece [state,0] == buttonId) {
			dialog.text = message [state,0];
			state++;
			blockButtons ();
		} else {
			dialog.text = message [state,1];
		}
	}

}
