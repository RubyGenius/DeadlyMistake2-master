using UnityEngine;
using System.Collections;

public class MenuPause : MonoBehaviour 
{
	private bool isPaused = false;
	public MouseLook scriptML;

	void Start(){
		scriptML = GetComponent<MouseLook> ();
	}

	// Use this for initialization
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape))
		    isPaused = !isPaused;

		if (isPaused) {
			Time.timeScale = 0f;

		}
		else
			Time.timeScale = 1.0f;
			foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
			scriptML.enabled = true;
	}
	void OnGUI()
	{
		if (isPaused) {
		
			foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
			scriptML.enabled = false;

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 - 20, 80, 40), "Continuer")) {
				isPaused = false;
				foreach(MouseLook scriptML in GetComponentsInChildren<MouseLook>())
					scriptML.enabled = true;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 20, 80, 40), "Options")) {
				isPaused = false;
			}

			if (GUI.Button (new Rect (Screen.width / 2 - 40, Screen.height / 2 + 60, 80, 40), "Quitter")) {
				Application.Quit ();
			}
		}
	}
}
