using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentController : MonoBehaviour {	
	//Public variables 
	[SerializeField]
	private float speed = 5f;
	[SerializeField]
	private float startX;
	[SerializeField]
	private float endX;
	[SerializeField]
	private float currentRndY;
	//Private variables 
	private Transform _transform;
	private Vector2 _currentPosition;
	// Use this for initialization
	void Start () {
		currentRndY = randomYcreator ();
		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;
		Reset ();
	}
	// Update is called once per frame
	void Update () {
		if (!GameController.gameOverStatus) {
			_currentPosition = _transform.position;
			_currentPosition -= new Vector2 (speed, 0);
			if (_currentPosition.x < endX)
				Reset ();
			_transform.position = _currentPosition;
		}
	}
	//reset the position for students 
	public void Reset(){
		currentRndY = randomYcreator ();
		_currentPosition = new Vector2 (startX ,currentRndY);
		_transform.position = _currentPosition;
	}
	//this creates a random Y to add students in random location
	public float randomYcreator(){
		return Random.Range (-160,291);
	}
	//play sound for collision with studensts
	public void PlaySound(){
		gameObject.GetComponent<AudioSource> ().Play ();
	}
}
