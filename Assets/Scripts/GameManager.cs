using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BGMusicVolume(Slider slide){
		BGMusic bgmusic = GameObject.Find ("BGMusic").GetComponent<BGMusic> ();
		bgmusic.BGMusicVolume (slide.value);
	}
}
