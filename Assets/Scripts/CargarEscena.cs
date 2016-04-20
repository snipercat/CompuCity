using UnityEngine;
using System.Collections;

public class CargarEscena : MonoBehaviour {

	public string Escena;
	public float time = 0;
	public bool onStart = false;

	public void Cargar(){
		Application.LoadLevel (Escena);
	}

	private void Espera() {
		
		System.Threading.Thread.Sleep ( System.TimeSpan.FromSeconds( time));
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
