using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Simple_Rotation : MonoBehaviour {
	public GameObject gameobjrot;

	public void Rotation(){
		gameobjrot.transform.Rotate (Vector3.up * Time.deltaTime * 45f, Space.World);
	}

	void Update(){
		Rotation ();
	} 
}
