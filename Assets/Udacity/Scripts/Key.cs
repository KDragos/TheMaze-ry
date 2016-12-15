using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject keyPoof;
    public GameObject door;

    public Image keyImage;
    public Sprite keyCollected;
    public Sprite keyMissing;

    void Start ()
	{
		keyImage = FindObjectOfType<Image>();
		keyImage.sprite = keyMissing;
	}

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
		Debug.Log("Key was clicked.");
		Instantiate(keyPoof, gameObject.transform.position, Quaternion.identity);
		keyImage.sprite = keyCollected;

        // Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();
        Destroy(gameObject);
    }

    public void ChangeKeyStatus() {
    	
    }

}
