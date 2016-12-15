using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour 
{
    public GameObject keyPoof;
    public GameObject door;

    // Image and sprites to indicate key status in HUD.
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
		
	}

	public void OnKeyClicked()
	{
		// Instantiate poof
		Transform keyHolder = this.transform.parent;
		GameObject createdPoof = (GameObject) Instantiate(keyPoof, keyHolder.transform.position, Quaternion.identity);
		createdPoof.transform.Rotate(-90f, 0f, 0f);

		// Change key icon to indicate collection of key.
		keyImage.sprite = keyCollected;

		// Unlock door.
		door.GetComponent<Door>().Unlock();

		// Destroy Key.
        Destroy(gameObject);
    }

    public void ChangeKeyStatus() {
    	
    }

}
