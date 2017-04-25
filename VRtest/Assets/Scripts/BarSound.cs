using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BarSound : MonoBehaviour {

	//The playback sound of the object
	public AudioClip sound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		GetComponent<AudioSource>().clip = sound;

		if (System.Math.Abs (col.relativeVelocity.magnitude) < 0.00001) {
			GetComponent<AudioSource>().volume = col.relativeVelocity.magnitude * 5000000;
			print(col.relativeVelocity.magnitude * 5000000);
		}
		else
		{
			GetComponent<AudioSource>().volume = col.relativeVelocity.magnitude;
			print(col.relativeVelocity.magnitude);
		}

		//GetComponent<AudioSource>().volume = 0f;
		GetComponent<AudioSource>().Play();
	}
}
