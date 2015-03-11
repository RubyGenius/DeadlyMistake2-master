using UnityEngine;
using System.Collections;

public class TP_Dalle_tospot: MonoBehaviour
{
	public GameObject Dalle_a_tp;
	public Transform Lieux_de_tp;

	void OnTriggerEnter(Collider my_col)
	{
		if(my_col.gameObject.name == "PERSO")
		{
			Dalle_a_tp.transform.position=Lieux_de_tp.position;
		}
	}

}