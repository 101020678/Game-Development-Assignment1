//Navid ghasemnejadnaybin 101020678
//Last Modified Octobre 18 2017 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour {
	//This car object has created to produce more 
	[SerializeField]
	GameObject car;
	//Labls and reset button for game over 
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
	//variables to track user
	private int carCounter=0;
	private int _life = 3;
	private int _score = 0;
	private int _highScore =0;
	public static bool gameOverStatus=false;
	public int Score{
		get{ return _score;}
		set
		{ _score = value;
			scoreLabel.text = "Score: " + _score;
			if (_score > _highScore) {
				_highScore = _score;
			}
			highScoreLabel.text = "Highest Score: " +  _highScore;
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
	//called at the game start up 
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
	//called when game over
	public void gameOver(){
		gameOverLabel.gameObject.SetActive (true);
		highScoreLabel.gameObject.SetActive (true);
		resetBtn.gameObject.SetActive (true);

		lifeLabel.gameObject.SetActive (false);
		scoreLabel.gameObject.SetActive (false);
		gameOverStatus = true;
	}
	//reset button event
	public void ResetBtnClick(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		gameOverStatus = false;
	}
	//add more cars 
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
