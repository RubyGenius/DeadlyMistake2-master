using UnityEngine;
using System.Collections;

public class RESTART_GRID : MonoBehaviour
{
	public GameObject dalles;
	public Transform dalles_pos;
	public GameObject perso;

	void OnTriggerEnter(Collider my_col)
	{
		if (my_col.gameObject.name == "PERSO")
		{
			dalles.transform.position=dalles_pos.position;
		}
	}

}
