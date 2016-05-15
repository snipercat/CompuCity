using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

public class CargarEscena : MonoBehaviour {

	public string Escena;
	public float time = 0;
	public bool onStart = false;
	public InputField Caja_Texto;

	public void Cargar(){
		SceneManager.LoadScene(Escena);
		//Application.LoadLevel (Escena);
	}

	public void Cargar(string escena){
		this.Escena = escena;
		Cargar ();
	}

	private void Espera() {
		
		System.Threading.Thread.Sleep ( System.TimeSpan.FromSeconds( time));
	}

	public void Verificar_Carga(string variable){
		if (Caja_Texto.text != "") {
			PlayerPrefs.SetString (variable, Caja_Texto.text);
			Cargar();
		}
	}

	// Use this for initialization
	void Start () {
		if(onStart){
			Debug.Log (time);
			Espera ();
			Cargar ();
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
