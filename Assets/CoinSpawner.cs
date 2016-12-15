using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour {

	public GameObject coin1;
	public GameObject coin5;

	// Use this for initialization
	void Start () {
		SpawnCoins();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos() {
		foreach (Transform child in transform) {
			Gizmos.color = Color.red;
			Gizmos.DrawWireSphere(child.position, 1f);
		}
    }

    private void SpawnCoins() {
		foreach (Transform child in transform) {
			float probabilityOfCoin = Random.value;
			if (probabilityOfCoin >= 0.4f) { // Determine the probability of spawning a coin.
				if (Random.value >= 0.4f) {
					Instantiate (coin1, child.position, Quaternion.identity); // Creates a coin worth 1 points. 
				} else {
					Instantiate (coin5, child.position, Quaternion.identity); // Creates a coin worth 5 points.
				}
			}
		}
    }
}
