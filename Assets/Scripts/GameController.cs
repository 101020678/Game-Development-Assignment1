﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
	[SerializeField]
	GameObject car;
	[SerializeField]
	Text lifeLabel;
	[SerializeField]
	Text scoreLabel;
	[SerializeField]
	Text gameOverLabel;
	[SerializeField]
	Text highScoreLabel;
	[SerializeField]
	Button resetBtn;
	private int carCounter=0;
	private int _life = 3;
	private int _score = 0;
	public int Score{
		get{ return _score;}
		set
		{ _score = value;
			scoreLabel.text = "Score: " + _score;
		}
	}
	public int Life{
		get{ return _life;}
		set{ _life = value;
			if (_life <= 0) {
				gameOver ();
			} else {
				lifeLabel.text = "Life: " + _life;
			}
		}
	}

	private void initialize(){
		Score = 0;
		Life = 3;
		gameOverLabel.gameObject.SetActive (false);
		highScoreLabel.gameObject.SetActive (false);
		resetBtn.gameObject.SetActive (false);
		lifeLabel.gameObject.SetActive (true);
		scoreLabel.gameObject.SetActive (true);
		StartCoroutine ("AddCar");
	}
	public void gameOver(){
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);

		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
	}
	public void ResetBtnClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}
	private IEnumerator AddCar(){
		if (carCounter < 6) {
			int time = 10;
			yield return new WaitForSeconds ((float) time);
			Instantiate (car);
			StartCoroutine ("AddCar");
			carCounter++;
		} 

	}
	// Use this for initialization
	void Start () {
		initialize ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}