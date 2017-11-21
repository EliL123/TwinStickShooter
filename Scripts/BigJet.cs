using UnityEngine;
using System.Collections;

public class BigJet : MonoBehaviour {

	public float Speed = 2f;
	public GameObject Player; 
	public Transform PlayerT;
	public float walkingDist = 25f;
	public int life; 
	public int i;

	Vector3 velocity; 


	Vector3 walkAmount;

	void Start(){
		life = 20;
	}

	void Update()
	{ 
		if (i==life) {

			Destroy (gameObject);
		}

		transform.LookAt(PlayerT);



		float distance = Vector3.Distance(transform.position, PlayerT.position);


		if (distance<walkingDist)
		{ 

			transform.position = Vector3.SmoothDamp(transform.position, PlayerT.position, ref velocity, Speed);

		}


	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Player"))
		{
			other.gameObject.SetActive (false);
		}
		if (other.gameObject.CompareTag ("Bullet")) {

			i++;

		}
	}
}
