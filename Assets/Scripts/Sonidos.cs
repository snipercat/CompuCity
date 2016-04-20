using UnityEngine;
using System.Collections;

public class Sonidos : MonoBehaviour {

	AudioSource audio;

	public void Musica(){
		audio = GetComponent<AudioSource> ();
		audio.enabled = !audio.enabled;
		//audio.volume = 1 - audio.volume;
	}

	public void Sonido(){
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
