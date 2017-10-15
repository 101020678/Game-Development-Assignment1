﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour {
	[SerializeField]
	float maxYspeed =2f;
	[SerializeField]
	float minYspeed =-2f;
	[SerializeField]
	float maxXspeed =11f;
	[SerializeField]
	float minXspeed =7f;

	private Transform _trasnsform;
	private Vector2 _currenSpeed;
	private Vector2 _currenPosition;
	// Use this for initialization
	void Start () {
		_trasnsform = gameObject.GetComponent<Transform> ();
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		_currenPosition = transform.position;
		_currenPosition -= _currenSpeed;
		_trasnsform.position = _currenPosition;
		if(_currenPosition.x<= -940){
			Reset ();
		}
		
	}
	void Reset()
	{
		float xSpeed = Random.Range (minXspeed, maxXspeed);
		float ySpeed = Random.Range (minYspeed, maxYspeed);

		_currenSpeed = new Vector2 (xSpeed,ySpeed);
		float y = Random.Range (-228,228);
		_trasnsform.position = new Vector2 (939 + Random.Range (0, 100), y);
	}
}
