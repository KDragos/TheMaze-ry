using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeySpawner : MonoBehaviour {

	public GameObject key;
	public Image keyImage;

    public Sprite keyCollected;
    public Sprite keyMissing;

    void Start ()
	{
		SpawnKey();
//		keyImage.sprite = keyMissing;
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
		Instantiate(key, this.gameObject.transform.GetChild(randomSpawnPont).position, Quaternion.identity);
	}

}
