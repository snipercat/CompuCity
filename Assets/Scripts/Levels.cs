using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Levels : MonoBehaviour {
	public Text dialog;


	private int[,] l1_secuece = { {1,2,3},
								  {1,0,0},
								  {0,1,0},
								  {1,1,1},};
	
	private string[,] l1_message = {{"Bien","Bien","Bien"}, 
									{"Mal","Mal","Mal"}};

	private string[] buttons = new string[]{"","Voltimetro","Cargador","Memoria"};

	private int[,] secuece;
	private string[,] message;
	private int state = 0;

	// Use this for initialization
	void Start () {
		int level=1;
		if( PlayerPrefs.HasKey("Level") )
			level = PlayerPrefs.GetInt ("Level");
		if (level == 1) {
			secuece = l1_secuece;
			message = l1_message;
		}
		//blockButtons ();
	
	}

	public void blockButtons(){
		Button boton;
		for (int c = 1; c < buttons.GetLength(0); c++) {
			try 
			{
				
				boton = GameObject.Find (buttons[c]).GetComponent<Button>();
				boton.interactable = secuece[c,state] == 1;
			}
			catch(System.Exception e)
			{
				Debug.Log (e.Message + '@'+ buttons [c] );
			}
		}
	}

	public void check(Button boton){
		int buttonId = 0;
		for (int c = 1; c < buttons.GetLength(0); c++) {
			if (buttons [c] == boton.name) {
				buttonId = c;
				break;
			}
		}

		
		if (secuece [0,state] == buttonId) {
			Debug.Log (message [0, state]);
			//dialog.text = message [0,state];
			state++;
			blockButtons ();
		} else {
			Debug.Log (message [1, state]);
			//dialog.text = message [1,state];
		}
	}

}
