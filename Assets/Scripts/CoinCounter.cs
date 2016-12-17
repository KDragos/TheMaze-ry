using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CoinCounter : MonoBehaviour {

	public Text scoreText; 

	private int maxScore = 0; 
	private int currentScore;

	public GameObject helpMessage;
    public Text messageText;

	// Use this for initialization
	void Start () {
		currentScore = 0;
	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = currentScore + " / " + maxScore;
	}

	public void ScorePoints (int pointValue)
	{
		currentScore += pointValue;
		Text message = (Text)Instantiate (messageText, helpMessage.transform, false);
		if (currentScore == maxScore) {
			message.text = "Great job collecting all the coins. Now get to work unlocking that door!";
		} else {
			message.text = "You've collected a coin with a point value of " + pointValue + "!";
		}
		Destroy(message, 5f);
	}

	public void SetMaxScore (int score) {
		maxScore = score;
	}
}
