using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Background_Sound : MonoBehaviour {

	public AudioClip audio_1;

	// Use this for initialization
	void Start () {
		Invoke("PlayAudio_1",0.0f);
	}

	void PlayAudio_1(){
		AudioSource.PlayClipAtPoint (audio_1, transform.position, 0.1f);
	}
}
