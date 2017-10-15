using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusController : MonoBehaviour {
	//Public variables 
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightX;
	[SerializeField]
	private float topY;
	[SerializeField]
	private float bottomY;

	//Private variables 
	private Transform _transform;
	private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;
		if (Input.GetKey (KeyCode.W)|| Input.GetKey(KeyCode.UpArrow)) {
			_currentPosition += new Vector2 (0, speed);
		}

		if (Input.GetKey (KeyCode.S)|| Input.GetKey(KeyCode.DownArrow)) {
			_currentPosition -= new Vector2 (0, speed);
		}

		if (Input.GetKey (KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow)) {
			_currentPosition -= new Vector2 (speed, 0);
		}

		if (Input.GetKey (KeyCode.D)|| Input.GetKey(KeyCode.RightArrow)) {
			_currentPosition += new Vector2 ( speed,0);
		}
		CheckBounds ();
		_transform.position = _currentPosition;
	}
	void CheckBounds(){
		if (_currentPosition.x < leftX)
			_currentPosition.x = leftX;
		if (_currentPosition.x > rightX)
			_currentPosition.x = rightX;
		if (_currentPosition.y > topY)
			_currentPosition.y = topY;
		if (_currentPosition.y < bottomY)
			_currentPosition.y = bottomY;
	}
}
