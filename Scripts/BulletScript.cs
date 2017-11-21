using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

	void OnTriggerEnter(Collider ot)
	{
		if (ot.gameObject.tag == "Enemy")
		{ 
			Destroy(gameObject); 
		}

		if (ot.gameObject.tag == "Out of Bounds") {

			Destroy(gameObject); 
		}
	}

}
