﻿//Navid ghasemnejadnaybin 101020678
//Last Modified Octobre 18 2017 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusCollision : MonoBehaviour {
	[SerializeField]
	GameController gameContoler;
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	//This method called when bus is collid with other objects 
	public void OnTriggerEnter2D (Collider2D other)
	{

		if (other.gameObject.tag.Equals ("car")) {
			//reset position of car
			other.gameObject.GetComponent<CarController> ().Reset ();
			//play sound of colliosn
			other.gameObject.GetComponent<CarController> ().PlaySound ();
			StartCoroutine( "Blink");
			gameContoler.Life--;
		} else if (other.gameObject.tag.Equals ("student")) {
			Debug.Log ("Collision Detected");
			other.gameObject.GetComponent<StudentController> ().PlaySound ();
			other.gameObject.GetComponent<StudentController> ().Reset ();
			gameContoler.Score += 100;
		}
	}
	//make the bus to blink 
	private IEnumerator Blink(){

		Color c;
		Renderer renderer = 
			gameObject.GetComponent<Renderer> ();
		for (int i = 0; i < 4; i++) {
			for (float f = 1f; f >= 0; f -= 0.3f) {
				c = renderer.material.color;
				c.a = f;
				renderer.material.color = c;
				yield return new WaitForSeconds (.1f);
			}
			for (float f = 0f; f <= 1; f += 0.3f) {
				c = renderer.material.color;
				c.a = f;
				renderer.material.color = c;
				yield return new WaitForSeconds (.1f);
			}
		}
	}
}
