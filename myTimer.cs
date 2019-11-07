using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class myTimer : MonoBehaviour {

	public float myCoolTimer = 300;
	public Text timerText;
	private bool timerIsActive = true;
	private float restartTimer;
	private float restartDelay = 3f;
	public static bool updateScore = true;


	// Use this for initialization
	void Start () {
		timerText = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		if(timerIsActive){
			myCoolTimer -= Time.deltaTime;
			timerText.text = myCoolTimer.ToString ("f0") + " seconds left.";
			//print (myCoolTimer);

			if(myCoolTimer <= 0){
				timerIsActive = false;
				updateScore = false;
				myCoolTimer = 0;
				timerText.fontSize = 250;
				timerText.text = "Game Over! \nPlease remove the headset.";

			}

		}
	}
}