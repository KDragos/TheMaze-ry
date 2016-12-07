using UnityEngine;
using System.Collections;

public class KeySpawner : MonoBehaviour {

	public GameObject key;

	// Use this for initialization
	void Start () {
		SpawnKey();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos() {
		foreach (Transform child in transform) {
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(child.position, 1);
		}
    }

    private void SpawnKey ()
	{
		int randomSpawnPont = Random.Range(0, transform.childCount);
		Debug.Log("Spawning key at point: " + randomSpawnPont.ToString());
		Instantiate(key, this.gameObject.transform.GetChild(randomSpawnPont).position, Quaternion.identity);
	}

}
