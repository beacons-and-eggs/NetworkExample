using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlay : MonoBehaviour {

	public AudioClip VHVoice;

	public void PlayAudio(){
		AudioSource.PlayClipAtPoint (VHVoice, transform.position);
	}
}
