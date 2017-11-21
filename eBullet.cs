using UnityEngine;
using System.Collections;

public class eBullet : MonoBehaviour {

	void OnTriggerEnter(Collider ot)
	{
		if (ot.gameObject.tag == "Player")
		{ 
			Destroy(gameObject); 
		}

		if (ot.gameObject.tag == "Out of Bounds") {

			Destroy(gameObject); 
		}
	}

}