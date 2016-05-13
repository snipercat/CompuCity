using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Saludo : MonoBehaviour {

	public Text Conversacion;
	public Button Opciones;
	public Button Siguiente;

	private int Level;

	// Use this for initialization
	void Start () {
		Level = PlayerPrefs.GetInt ("Level");
		switch (Level)
		{
		case 1:
			Conversacion.text = "Cliente: Hola. Soy Sofía. El PC no enciende.";
		break;
		case 2:
			Conversacion.text = "Cliente: Hola. Soy María. El PC está lento.";
		break;
		}

		Opciones.gameObject.SetActive(true);
		Siguiente.gameObject.SetActive(false);
	}

	public void Constestar(int Opcion){
		string jugador = PlayerPrefs.GetString("Jugador");
		string tienda = PlayerPrefs.GetString("Tienda");

		if (Opcion == 1) {
			Conversacion.text += "\n"+jugador+": Hola. Soy "+jugador+", bienvenido a "+tienda;
			Opciones.gameObject.SetActive(false);
			Siguiente.gameObject.SetActive(true);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
