using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour 
{
	private bool isPaused = false;
	public MouseLook scriptML;
	public Transform spawn;
	public GameObject perso;

	void Start(){
		scriptML = GetComponent<MouseLook> ();
	}

	// Use this for initialization
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.R))
			perso.transform.position = spawn.position;

		if (Input.GetKeyDown (KeyCode.Escape))
		    isPaused = !isPaused;
			AudioListener.pause = isPaused;
		
		if (isPaused) {
			Time.timeScale = 0f;
			Screen.showCursor = true;

		} 
		else {
			Time.timeScale = 1.0f;
			Screen.showCursor = false;
			foreach (MouseLook scriptML in GetComponentsInChildren<MouseLook>()) 
				scriptML.enabled = true;
		}
	}
	void OnGUI()
	{
		if (isPaused) {
		
			foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
			scriptML.enabled = false;

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 60, 80, 40), "Continue")) {
				isPaused = false;
				Screen.showCursor = false;
				foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Restart")) {
				perso.transform.position = spawn.position;
				Screen.showCursor = false;
				isPaused = false;
				foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 20, 80, 40), "Options")) {
				isPaused = false;
				Screen.showCursor = false; 
				foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 60, 80, 40), "Quit")) {
				Application.Quit ();
			}
		}
	}
}
