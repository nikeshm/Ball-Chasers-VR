using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleTimer : MonoBehaviour {

	public float myTitleTimer = 20;
	public Text titleTimerText;
	private bool timerIsActive = true;
	[SerializeField]
	private string loadLevel;


	// Use this for initialization
	void Start () {
		titleTimerText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if(timerIsActive){
			myTitleTimer -= Time.deltaTime;
			titleTimerText.text = "The game begins in " + myTitleTimer.ToString ("f0") + " seconds.";
			//print ("The game begins in " + myTitleTimer + " seconds.");

			if(myTitleTimer <= 0){
				timerIsActive = false;
				myTitleTimer = 0;
				SceneManager.LoadScene (loadLevel);

			}

		}
	}
}
