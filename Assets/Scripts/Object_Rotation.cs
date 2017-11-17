using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider))]
public class Object_Rotation : MonoBehaviour{
	private bool checkRot;
	public GameObject gameobjrot;
	//	public GvrAudioSource script;
	private int counterobj;

	void Start(){
		SetGazedAt(false);
	}

	public void SetGazedAt(bool gazedAt){
			counterobj++;
			if (counterobj % 2 == 0){
				checkRot = true;
			} 
			else{
				checkRot = false;
			}
				
			return;
		}
		
	public void Rotation(){
		gameobjrot.transform.Rotate (Vector3.up * Time.deltaTime * 45f, Space.World);
	}

	void Update(){
		if (checkRot == true){
			Rotation ();
		} 
	}
}
