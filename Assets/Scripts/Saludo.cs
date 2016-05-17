using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Saludo : MonoBehaviour {

	public Text Conversacion;
	public Button Opciones;
	public Button Ignorar;
	public Button Siguiente;


	private int Level;

	// Use this for initialization
	void Start () {
		Level = PlayerPrefs.GetInt ("Level");
		PlayerPrefs.SetInt ("Saludo", 0);
		switch (Level)
		{
		case 1:
			Conversacion.text = "Cliente: Hola. Soy Sofía. El PC no enciende.";
		break;
		case 2:
			Conversacion.text = "Cliente: Hola. Soy María. El PC está lento.";
		break;
		case 3:
			Conversacion.text = "¡Buenas tardes! Necesito actualizar el sistema operativo";
			break;
		case 4:
			Conversacion.text = "¡Buenas tardes! La memoria del PC es insuficiente";
			break;
		case 5:
			Conversacion.text = "Hola, el pc Se descarga muy rápido.";
			break;
		}

		//Opciones.gameObject.SetActive(true);
		//Siguiente.gameObject.SetActive(false);
	}

	public void Constestar(int Opcion){

		PlayerPrefs.SetInt ("Saludo", 1);

		string jugador = PlayerPrefs.GetString("Jugador");
		string tienda = PlayerPrefs.GetString("Tienda");

		if (Opcion == 1) {
			Conversacion.text += "\n"+jugador+": Hola. Soy "+jugador+", bienvenido a "+tienda+", Yo puedo solucionarlo! :D";
			Opciones.gameObject.SetActive(false);
			Ignorar.gameObject.SetActive(false);
			Siguiente.gameObject.SetActive(true);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
