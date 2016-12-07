using UnityEngine;
using System.Collections;

public class WallSpawner : MonoBehaviour {

	public GameObject[] wallSpawnPoints;
	public GameObject wall;

	// Use this for initialization
	void Start () {
		GenerateWalls();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDrawGizmos() {
		foreach (Transform child in transform) {
			Gizmos.color = Color.blue;
			Gizmos.DrawWireCube(child.position, new Vector3(1f, 1f, 1f));
		}
    }

    private void GenerateWalls ()
	{
		foreach (Transform child in transform) {
			if (Random.value >= 0.5f) { // Determine the probability of spawning a wall.
				if (Random.value >= 0.5f) {
					Instantiate (wall, child.position, Quaternion.identity); // Keeps the wall's original rotation.
				} else {
					Instantiate (wall, child.position, Quaternion.Euler(new Vector3(0f, 90f, 0f))); // Rotates the wall by 90 degrees.
				}
			}
		}
	}
}
