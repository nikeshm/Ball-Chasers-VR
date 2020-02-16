using UnityEngine;
using System.Collections;

public class CoinPickup : MonoBehaviour {

	public GameObject prefab;
	private float spawnArea = 2f;

	void OnTriggerEnter(Collider other) {

		//...update the score...
		ScoreCounter.score++;


		Vector3 coinPosition = new Vector3(Random.Range(-20f, 20f), 0f, Random.Range(-20f, 20f));


		Instantiate (prefab, coinPosition, Quaternion.identity);

		Destroy (gameObject);

	}
}
