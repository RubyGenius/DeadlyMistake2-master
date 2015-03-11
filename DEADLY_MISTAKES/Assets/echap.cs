using UnityEngine;
using System.Collections;

public class echap : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update (int scene) {
		if (Input.GetKeyDown ("escape")) {
			Application.LoadLevel(scene);
		}
	}
}
