using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Levels : MonoBehaviour {
	public Text dialog;
	public GameObject MenuRespuesta;
	public GameObject FondoFin;
	public GameObject 	  BotonFin;

	private int[,] l1_secuence = { {1,2}, //Correcto
								  {1,0},//1 - Voltimetro
								  {0,1},//2 - Cargador
							 	  {1,1},//3 - Memoria
								  {0,0},//4 - Disco Duro
								  {0,0},//5 - Bateria
								  {0,0},//6 - Destornillador
								  {0,0},//7 - Soplador
								  {0,0},//8 - Antivirus
								  {0,0},//9 - Sistema
								  {0,0},//10 - Programas
		};
	
	private string[,] l1_message = {{"Debo medir la electricidad","Al parecer la fuente de energía no funciona","¡El computador ya funciona!"}, 
									{"Esto no arregla el problema","Esto no arregla el problema",""}};
/// <summary>
/// ////////////////////////////////////////
/// </summary>
	private int[,] l2_secuence = {  {8,6,7,6}, //Correcto
									{0,0,0,0},//1 - Voltimetro
									{0,0,0,0},//2 - Cargador
									{0,0,1,1},//3 - Memoria
									{1,0,0,0},//4 - Disco Duro
									{0,0,0,0},//5 - Bateria
									{1,1,1,1},//6 - Destornillador
									{1,1,1,1},//7 - Soplador
									{1,0,0,0},//8 - Antivirus
									{0,0,0,0},//9 - Sistema
									{0,0,0,0},//10 - Programas
	};

	private string[,] l2_message = {{"Seguramente el PC tiene virus","Ya no tiene Virus, pero ¿Cómo quieren que sea rápido si está sucio?","Ahora si lo puedo limpiar","Falta algo más para entregarlo","¡Ya puedo entregarlo!"}, 
									{"Esto no arregla el problema"  ,"No lo puedo limpiar si está sellado","Aún no lo he limpiado","No debo hacerle más cambios",""}};
	
/// <summary>
/// ////////////////////////////////////////
/// </summary>


	private string[] buttons = new string[]{"","Voltimetro","Cargador","Memoria", "DiscoDuro", "Bateria","Destornillador","Soplador","Antivirus","Sistema","Programas"};

	private int[,] secuence; //Matriz que indica 
	private string[,] message;
	private int state = 0;

	// Use this for initialization
	void Start () {
		state = 0;
		int Level = PlayerPrefs.GetInt ("Level");
		switch (Level) {
		case 1:
			secuence = l1_secuence;
			message = l1_message;
		break;
		case 2:
			secuence = l2_secuence;
			message = l2_message;
		break;
		}
		//}
		//blockButtons ();
		Debug.Log("State= "+state+ "Message: "+message [0,state]);
		showMessage(message [0,state]);
		Debug.Log("State= "+state);
		//MenuRespuesta.SetActive (true);
	}

	public void blockButtons(){
		Button boton;
		for (int c = 1; c < buttons.GetLength(0); c++) {
			try 
			{
				
				boton = GameObject.Find (buttons[c]).GetComponent<Button>();
				boton.interactable = secuence[c,state] == 1;
			}
			catch(System.Exception e)
			{
				//Debug.Log (e.Message + '@'+ buttons [c] );
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

		
		if (secuence [0,state] == buttonId) {
			//Debug.Log (message [0, state]);
			state++;
			showMessage(message [0,state]);
			blockButtons ();
		} else {
			showMessage(message [1,state]);
			//Debug.Log ("Eso no solucionará el problema");
			//dialog.text = message [1,state];
		}


		if(secuence.GetLength(1)==state){
			FondoFin.SetActive (true);
			BotonFin.SetActive (true);
		}
	}

	public void showMessage(string texto){
		MenuRespuesta.SetActive (true);
		dialog.text = texto;
	}

	public void LevelComplete(){
		//Si el jugador está jugando el nivel máximo en el que va, progresa un nivel.
		int PlayerLevel = PlayerPrefs.GetInt ("PlayerLevel");
		int CurrLevel = PlayerPrefs.GetInt("Level");
		Debug.Log ("PlayerLevel:"+PlayerLevel+"-CurrLevel: "+CurrLevel);
		if (PlayerLevel == CurrLevel && PlayerLevel != 5) {
			PlayerPrefs.SetInt ("PlayerLevel", PlayerLevel + 1);
		}

		//CargarEscena escena decimal seleccion decimal nivel
		CargarEscena cargar = gameObject.GetComponent<CargarEscena> ();
		cargar.Cargar ("3. Niveles");
	}

}
