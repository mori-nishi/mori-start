using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgm : MonoBehaviour {
	public AudioClip car_clip;
	private AudioSource car_source;
	bool On;

	// Use this for initialization
	void Start () {
		AudioSource car_source = gameObject.GetComponent<AudioSource>();
		car_source.clip = car_clip;
		car_source.Stop();
		//car_source.Play();
		On=false;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)) {
			On = true;
			car_source.Play();
		}

	}

}
