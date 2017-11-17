using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render_Function_Child : MonoBehaviour {

	public Renderer[] gameobjrender;
	public BoxCollider gameobjcoll;

	public void gameObjectRenderingChildren(){
		gameobjrender = GetComponentsInChildren<Renderer> ();
		gameobjcoll = gameobjcoll.gameObject.GetComponent<BoxCollider> ();
		foreach (Renderer children in gameobjrender) {
			if (children.enabled == true) {
				children.enabled = false;
				gameobjcoll.enabled = false;
			} else if (children.enabled == false) {
				children.enabled = true;
				gameobjcoll.enabled = true;
			}
		}
	}
}
