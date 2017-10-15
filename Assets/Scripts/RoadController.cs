using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadController : MonoBehaviour {
	//Public variables 
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;





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
		_currentPosition -= new Vector2 (speed, 0);
		_transform.position = _currentPosition;
	}
}
