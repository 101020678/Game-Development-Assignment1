﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter2D(Collider2D other)
	{
		Debug.Log("Collision Detected");
		if (other.gameObject.tag.Equals ("car")) {
			Debug.Log("good stuff");
		}
		other.gameObject.GetComponent<CarController> ().Reset ();
	}
}
