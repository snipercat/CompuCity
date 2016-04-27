using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void BGMusicEnable(){
		
		AudioSource BGMusic =  GameObject.Find("BGMusic").GetComponent<AudioSource>();
		if (BGMusic.isPlaying) {
			BGMusic.Stop ();
			PlayerPrefs.SetInt("BGMusic", 0);
		} else {
			BGMusic.Play ();
			PlayerPrefs.SetInt("BGMusic", 1);
		}
	}


}
