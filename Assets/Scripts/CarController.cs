using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
	[SerializeField]
	float maxYspeed =5f;
	[SerializeField]
	float minYspeed =10f;
	[SerializeField]
	float maxXspeed =-2f;
	[SerializeField]
	float minXspeed =2f;

	private Transform _trasnsform;
	private Vector2 _currenSpeed;
	private Vector2 _currenPosition;
	// Use this for initialization
	void Start () {
		_trasnsform = gameObject.GetComponents<Transform> ();
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Reset()
	{
		float xSpeed = Random.Range (minXspeed, maxXspeed);
		float ySpeed = Random.Range (minYspeed, maxYspeed);

		_currenSpeed = new Vector2 (xSpeed,ySpeed);
	}
}
