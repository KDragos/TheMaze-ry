using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour 
{
    private bool locked;
    public AudioSource audioSource;
    public AudioClip doorLocked;
    public AudioClip doorUnlocked;

    public GameObject helpMessage;
    public Text messageText;

    void Start ()
	{
		locked = true;
//		audioSource = FindObjectOfType<AudioSource>();
//		Debug.Log(audioSource.enabled);
//		audioSource.clip = doorLocked;
//		audioSource.Play();

	}

    void Update ()
	{
		// If the door is unlocked and it is not fully raised
		if (locked) {
			// Animate the door raising up

		}
    }

    public void Unlock()
    {
        locked = false;
        Debug.Log("Door is now unlocked.");
		Debug.Log(GetComponent<AudioSource>().ToString());
        audioSource.clip = doorUnlocked;
        audioSource.Play();

        Text message = (Text) Instantiate(messageText, helpMessage.transform, false);
        message.text = "You've unlocked the door. Now you must find it to win.";
		Destroy(message, 5f);
        Debug.Log("Created message.");
    }

    public void Open ()
	{
		if (locked) {
			Text message = (Text) Instantiate(messageText, helpMessage.transform, false);
        	message.text = "This door is locked. There must be some way to open it.";
        	Destroy(message, 5f);

		} else {
			Text message = (Text) Instantiate(messageText, helpMessage.transform, false);
        	message.text = "Congratulations!";
			Destroy(message, 5f);
		}

    }
}
