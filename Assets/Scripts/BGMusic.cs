﻿using UnityEngine;
using System.Collections;

public class BGMusic : MonoBehaviour {


	// Use this for initialization
	void Start () {
		if(!PlayerPrefs.HasKey("BGMusic") )
			PlayerPrefs.SetInt("BGMusic", 1);

		if (PlayerPrefs.GetInt ("BGMusic") == 1) {
			AudioSource BGMusic = gameObject.GetComponent<AudioSource> ();
			BGMusic.Play();
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BGMusicEnable(){
		AudioSource BGMusic =  gameObject.GetComponent<AudioSource>();
		if (BGMusic.isPlaying) {
			BGMusic.Stop ();
			PlayerPrefs.SetInt("BGMusic", 0);
		} else {
			BGMusic.Play ();
			PlayerPrefs.SetInt("BGMusic", 1);
		}
	}
}