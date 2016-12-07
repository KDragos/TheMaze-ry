using UnityEngine;
using System.Collections;

public class KeySpawner : MonoBehaviour {

	public GameObject[] spawnPoints;
	public GameObject key;

	// Use this for initialization
	void Start () {
		SpawnKey();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos() {
		for (int i = 0; i < spawnPoints.Length; i++) {
			Gizmos.color = Color.yellow;
			Gizmos.DrawWireSphere(spawnPoints[i].transform.position, 1);
		}
    }

    private void SpawnKey ()
	{
		int randomSpawnPont = Random.Range(0, spawnPoints.Length);
		Debug.Log("Spawning key at point: " + randomSpawnPont.ToString());
		Instantiate(key, spawnPoints[randomSpawnPont].transform.position, Quaternion.identity);
	}

}
