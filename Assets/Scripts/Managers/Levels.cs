using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Levels : MonoBehaviour {
	public Text dialog;
	public GameObject MenuRespuesta;
	public GameObject FondoFin;
	public GameObject 	  BotonFin;
	public Text TextMovementLeft;
	public GameObject MenuDerrota;

	private string[] buttons = new string[]{"","Voltimetro","Cargador","Memoria", "DiscoDuro", "Bateria","Destornillador","Soplador","Antivirus","Sistema","Programas"};

	private int[,] secuence; //Matriz que indica 
	private string[,] message;
	private int state = 0;
	private int movements;
	private string tip;
	//public int loadLevel;

	// Use this for initialization
	void Start () {
		state = 0;
		int Level = PlayerPrefs.GetInt ("Level");
		//int Level = loadLevel;

		 // Obtener el mensaje y la secuenca para el nivel.
		secuence = LevelsMatrix.getSecuence (Level);
		switch (Level) {
		case 1:
			message = LevelsMatrix.getMessage_tut (Level);
			break;
		default:
			message = LevelsMatrix.getMessage (Level);
			break;
		}

		showMessage(message [0,state]);
		tip = message [0, state];
		movements = getTryByLevel ();
		TextMovementLeft.text = movements.ToString();
		//MenuRespuesta.SetActive (true);
	}


/// <summary>
/// Bloquea los botones de acuerdo a la infomración de la matriz de la secuencia del nivel.
/// </summary>
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




/// <summary>
/// Procedimiento proncipal del flujo del juego
/// </summary>
/// <param name="boton">Boton.</param>
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
			tip = message [0, state];
			blockButtons ();
		} else {
			showMessage(message [1,state]);
			//Debug.Log ("Eso no solucionará el problema");
			//dialog.text = message [1,state];
		}


		if (secuence.GetLength (1) == state) {
			FondoFin.SetActive (true);
			BotonFin.SetActive (true);
		} else {
			movements--;
			TextMovementLeft.text = movements.ToString();

			if (movements < 0) {
				MenuDerrota.SetActive (true);
			}
		}


	}



/// <summary>
/// Muestra el mensaje en la pantalla y lo actualiza
/// </summary>
/// <param name="texto">Texto.</param>
	public void showMessage(string texto){
		MenuRespuesta.SetActive (true);
		dialog.text = texto;
	}


/// <summary>
/// Solo Muestra el mensaje 
/// </summary>
	public void showTip(){
		MenuRespuesta.SetActive (true);
		dialog.text = tip;
	}

/// <summary>
/// Muestra el mensaje cuando se completa el juego
/// </summary>
	public void LevelComplete(){
		//Si el jugador está jugando el nivel máximo en el que va, progresa un nivel.
		int PlayerLevel = PlayerPrefs.GetInt ("PlayerLevel");
		int CurrLevel = PlayerPrefs.GetInt("Level");
		Debug.Log ("PlayerLevel:"+PlayerLevel+"-CurrLevel: "+CurrLevel);
		if (PlayerLevel == CurrLevel && PlayerLevel != 5) {
			PlayerPrefs.SetInt ("PlayerLevel", PlayerLevel + 1);
		}

		//CargarEscena escena decimal seleccion decimal nivel
		FUNCTIONS.LOAD_SCENE (VARIABLES.Niveles);

	}


/// <summary>
/// Obtiene la cantidad de movimientos que tendrá el jugador por nivel
/// Basado en la cantidad de opciones que tendrá dividido en 2.
/// </summary>
/// <returns>The try by level.</returns>
	private int getTryByLevel(){

		int options = 0;
		//Si no saludó, no puede fallar ni una (por maleducado :v)
		if(PlayerPrefs.GetInt ("Saludo") == 0)
			return secuence.GetLength (1);

			//Si saludó, obtiene más intentos.
		for (int tool = 1; tool < secuence.GetLength (0); tool++) {
			for (int phase = 0; phase < secuence.GetLength (1); phase++)
				options += secuence [tool, phase];
		}

		return Mathf.CeilToInt (options / 2);
	}

	public void restarLevel(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Dialogo);
	}

	public void goHome(){
		FUNCTIONS.LOAD_SCENE (VARIABLES.Menu);
	}

}
