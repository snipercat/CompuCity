using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Levels : MonoBehaviour {
	public Text dialog;
	public GameObject MenuRespuesta;

	private int[,] l1_secuece = { {1,2}, //Correcto
								  {1,0}, //Voltimetro
								  {0,1},//Cargador
							 	  {0,1},//Memoria
								  {0,0},//Disco Duro
								  {0,0},//Bateria
								  {0,0},//Destornillador
								  {0,0},//Soplador
								  {0,0},//Antivirus
								  {0,0},//Sistema
								  {0,0},//Programas
		};
	
	private string[,] l1_message = {{"Debo medir la electricidad","Al parecer la fuente de energía no funciona","¡El computador ya funciona!"}, 
									 {"Mal","Esto no arregla el problema","Esto no arregla el problema"}};

/// <summary>
/// ////////////////////////////////////////
/// </summary>


	private string[] buttons = new string[]{"","Voltimetro","Cargador","Memoria", "DiscoDuro", "Bateria","Destornillador","Soplador","Antivirus","Sistema","Programas"};

	private int[,] secuece; //Matriz que indica 
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
		showMessage(message [0,state]);
		MenuRespuesta.SetActive (true);
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
			//Debug.Log (message [0, state]);
			state++;
			showMessage(message [0,state]);
			blockButtons ();
		} else {
			showMessage(message [1,state]);
			//Debug.Log ("Eso no solucionará el problema");
			//dialog.text = message [1,state];
		}
	}

	public void showMessage(string texto){
		MenuRespuesta.SetActive (true);
		dialog.text = texto;
	}

}
