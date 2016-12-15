using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

	public Text scoreText; 

	private int maxScore = 0; 
	private int currentScore;

	// Use this for initialization
	void Start () {
		currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = currentScore + " / " + maxScore;
	}

	public void ScorePoints (int pointValue) {
		currentScore += pointValue;
	}

	public void SetMaxScore (int score) {
		maxScore = score;
	}
}
