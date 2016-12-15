using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Quit ()
	{
		Debug.Log("Quitting game");
		Application.Quit();
	}

	public void Replay() {
		SceneManager.LoadScene("Maze");
	}
}
