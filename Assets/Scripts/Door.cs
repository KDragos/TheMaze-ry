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

    public GameObject winningUI;
    public GameObject helpMessage;
    public Text messageText;

    void Start ()
	{
		locked = true;
		winningUI.SetActive(false);
	}

    void Update ()
	{

    }

    // Unlocks the door so that when the door is clicked on next, it will open.
    public void Unlock()
    {
        locked = false;
        audioSource.clip = doorUnlocked;
        audioSource.Play();

        Text message = (Text) Instantiate(messageText, helpMessage.transform, false);
        message.text = "You've unlocked the door. Now you must find it to win.";
		Destroy(message, 5f);
    }

    // If the door is locked, users get a message.
    // If teh door is unlocked, users will be able to open the door.
    public void Open ()
	{
		if (locked) {
			Text message = (Text) Instantiate(messageText, helpMessage.transform, false);
        	message.text = "This door is locked. There must be some way to open it.";
        	Destroy(message, 5f);
		} else {
			Text message = (Text) Instantiate(messageText, helpMessage.transform, false);
			gameObject.GetComponent<Animator>().SetBool("HasKey", true);
        	message.text = "Congratulations!";
        	winningUI.SetActive(true);
			Destroy(message, 5f);
		}

    }
}
