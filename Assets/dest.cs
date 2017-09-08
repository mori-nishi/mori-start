using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "cube") {
			Debug.Log ("ok");
		}

	}

}
