using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro_Timed_Activations : MonoBehaviour {

	public Material sphere_1;
	public Material sphere_2;
	public Material sphere_3;
	public Material sphere_4;
	public Material sphere_5;
	public Material sphere_6;

	public AudioClip audio_1;
	public AudioClip audio_2;
	public AudioClip audio_3;
	public AudioClip audio_4;

	public float time_trigger;

	public Renderer sphere;
	public Renderer gameobjrender_1;
	public Renderer gameobjrender_2;
	public Renderer gameobjrender_3;
	public SpriteRenderer spriterender;
	public string sceneToChangeTo;

	void Start () {
		gameobjrender_1.enabled= false;
		gameobjrender_2.enabled= false;
		gameobjrender_3.enabled= false;
		spriterender.enabled = false;
//		audioSource = GetComponent<AudioSource> ();
		Invoke("PlayAudio_1",0.0f);
		Invoke("PlayAudio_2",4.55f);
		Invoke("PlayAudio_3",6.25f);
		Invoke("PlayAudio_4",39f);

	}

	void Update () {
		time_trigger = Time.timeSinceLevelLoad;
		Debug.Log (time_trigger);
		if (time_trigger < 10) {
			sphere.material = sphere_1;
//			if (!audioSource.isPlaying) {
//				audioSource.PlayOneShot (audio_1, .5f);
//			}
//			audioSource.Stop ();
		}
		else if(time_trigger >=11.65 && time_trigger < 18){
			gameobjrender_1.enabled= true;
		}
		else if(time_trigger >=18 && time_trigger < 21){
			gameobjrender_1.enabled= false;
			sphere.material = sphere_2;
		}
		else if(time_trigger >=21 && time_trigger < 24){
			sphere.material = sphere_3;
		}
		else if(time_trigger >=24 && time_trigger < 28){
			sphere.material = sphere_4;
		}
		else if(time_trigger >=28 && time_trigger < 32){
			sphere.material = sphere_5;
		}
		else if(time_trigger >=32 && time_trigger < 36){
			sphere.material = sphere_6;
		}
		else if(time_trigger >=36 && time_trigger < 38){
			sphere.material = sphere_1;
		}
		else if(time_trigger >=38 && time_trigger < 44){
			gameobjrender_2.enabled= true;
			gameobjrender_3.enabled= true;
			spriterender.enabled = true;
		}
		else if(time_trigger > 61){
			SceneManager.LoadScene (sceneToChangeTo);
		}


	}

	void PlayAudio_1(){
		AudioSource.PlayClipAtPoint (audio_1, transform.position);
	}
	void PlayAudio_2(){
		AudioSource.PlayClipAtPoint (audio_2, transform.position);
	}
	void PlayAudio_3(){
		AudioSource.PlayClipAtPoint (audio_3, transform.position);
	}
	void PlayAudio_4(){
		AudioSource.PlayClipAtPoint (audio_4, transform.position);
	}
}
