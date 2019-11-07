using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {

	public static int score;
	private Text scoreCounterText;

	// Use this for initialization
	void Start () {
		myTimer.updateScore = true;
		score = 0;
		scoreCounterText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if (myTimer.updateScore == true) {
			scoreCounterText.text = "You have " + score + " fruits.";

		}

	}
}