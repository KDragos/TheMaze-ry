using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    private bool locked;
    public AudioSource audioSource;
    public AudioClip doorLocked;
    public AudioClip doorUnlocked;

    void Start ()
	{
		locked = true;
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
        // You'll need to set "locked" to true here
        locked = false;
        Debug.Log("Door is now unlocked.");
		Debug.Log(audioSource.enabled);
        audioSource.clip = doorUnlocked;
        audioSource.Play();

    }
}
