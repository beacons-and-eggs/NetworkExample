using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Render_Objects_with_Children : MonoBehaviour {

	public Material inactiveMaterial;
	public Material gazedAtMaterial;

	public SpriteRenderer spriterender;
//	public Renderer[] gameobjrender;
	private int counter;
	public Render_Function_Child Object_with_Children_Mesh;
	public AudioPlay scriptPlayAudio;

	//	public GvrAudioSource script;
	//	private bool checkview;
	//	private float timer;

	void Start(){
		SetGazedAt(false);
	}

	public void SetGazedAt(bool gazedAt){
		if (inactiveMaterial != null && gazedAtMaterial != null){
			counter++;
			GetComponent<Renderer>().material = gazedAt ? gazedAtMaterial : inactiveMaterial;
			if (counter % 2 == 0){
				SpriteRendering();
				gameObjectRender();
//				gameObjectRenderingChildren ();
				//				script.Play ();
				//				checkview = true;

			} 
			//			else 
			//			{
			//				checkview = false;
			//				timer = 0;
			//			}
			return;
		}
		GetComponent<Renderer>().material.color = gazedAt ? Color.green : Color.red;
	}

	public void SpriteRendering(){
		spriterender = spriterender.gameObject.GetComponent<SpriteRenderer> ();
		if (spriterender.enabled == true){
			spriterender.enabled= false;
		}
		else if (spriterender.enabled == false){
			spriterender.enabled= true;
		}
	}


	public void gameObjectRender(){
		Object_with_Children_Mesh.gameObjectRenderingChildren();
	}

	public void PlayAudioinGame(){
		scriptPlayAudio.PlayAudio ();
	}

//	public void gameObjectRenderingChildren(){
//		gameobjrender = GetComponentsInChildren<Renderer> ();
//		foreach (Renderer children in gameobjrender) {
//			Debug.Log ("step1");
//			if (children.enabled == true){
//				children.enabled= false;
//				Debug.Log ("step2");
//				//			Debug.Log ("On");
//			}
//			else if (children.enabled == false){
//				children.enabled= true;
//				Debug.Log ("step2");
//				//			Debug.Log ("Off");
//			}
//		}
//	}

	//I need to ask about this
	//	void Update(){
	//		if (checkview == true) {
	//			timer += Time.time;
	//			if (timer >= 100 && timer <= 102) {
	//				SpriteRendering ();
	//				gameObjectRendering ();
	//				//				script.Play ();
	//			}
	//		}
	//	}
}
