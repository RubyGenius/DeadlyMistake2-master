using UnityEngine;
using System.Collections;

public class jouer : MonoBehaviour {

	public void changescene(int scene)
	{
		Application.LoadLevel(scene);
	}
}
