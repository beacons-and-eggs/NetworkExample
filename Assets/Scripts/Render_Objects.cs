using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Collider))]
public class Render_Objects: MonoBehaviour{

	public Material inactiveMaterial;
	public Material gazedAtMaterial;

	public SpriteRenderer spriterender;
	public Renderer gameobjrender;
	public BoxCollider gameobjcoll;
	public AudioPlay scriptPlayAudio;
	private int counter;

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
				SpriteRendering ();
				gameObjectRendering ();
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

	public void gameObjectRendering(){
		gameobjrender = gameobjrender.gameObject.GetComponent<Renderer> ();
		gameobjcoll = gameobjcoll.gameObject.GetComponent<BoxCollider> ();
		if (gameobjrender.enabled == true){
			gameobjrender.enabled= false;
			gameobjcoll.enabled = false;
			//			Debug.Log ("On");
		}
		else if (gameobjrender.enabled == false){
			gameobjrender.enabled= true;
			gameobjcoll.enabled = true;
			//			Debug.Log ("Off");
		}
	}

	public void PlayAudioinGame(){
		scriptPlayAudio.PlayAudio ();
	}

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
	