using UnityEngine;
using System.Collections;

public class MORT_restart : MonoBehaviour {

	public Transform spawn;
	public GameObject perso;

	void OnTriggerEnter(Collider my_col)
	{
		if(my_col.gameObject.name == "PERSO")
		{
			perso.transform.position = spawn.position;
		}
	}
}