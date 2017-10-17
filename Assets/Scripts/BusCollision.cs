using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusCollision : MonoBehaviour {
	
	// Use this for initialization
	void Start () {

	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerEnter2D (Collider2D other)
	{
		//Debug.Log ("Collision Detected");
		if (other.gameObject.tag.Equals ("car")) {
			//Debug.Log ("good stuff");
			other.gameObject.GetComponent<CarController> ().Reset ();
			other.gameObject.GetComponent<CarController> ().PlaySound ();
			StartCoroutine( "Blink");
		} else if (other.gameObject.tag.Equals ("student")) {
			Debug.Log ("Collision Detected");
			other.gameObject.GetComponent<CarController> ().PlaySound ();
		}
	}
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
