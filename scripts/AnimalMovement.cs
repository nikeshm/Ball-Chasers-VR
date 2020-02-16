using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalMovement : MonoBehaviour {

	float timeCounter;
	float speed;
	float width;
	float length;


	// Use this for initialization
	void Start () {
		timeCounter = 0;
		speed = 20;
		width = 0.5f;
		length = 0.5f;

	}

	// Update is called once per frame
	void Update () {
		timeCounter += Time.deltaTime * speed;
		float x = Mathf.Cos (timeCounter) * width;
		float y = 0;
		float z = Mathf.Sin (timeCounter) * length;
		transform.position = new Vector3 (x, y, z);
	}


}
