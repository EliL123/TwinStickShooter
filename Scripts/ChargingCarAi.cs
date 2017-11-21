using UnityEngine;
using System.Collections;

public class ChargingCarAi : MonoBehaviour
{

	public float maxSpeed = 2f;
	public GameObject Player; 
	public Transform PlayerT;
	public float walkingDistance = 15f;
	public int life; 
	private int i;

	Vector3 velocity; 


	Vector3 walkAmount;


	void Start (){
		life = 3; 
	
	}


	void Update()
	{ 

		if (i==life) {

			Destroy (gameObject);
		}
		transform.LookAt(PlayerT);



		float distance = Vector3.Distance(transform.position, PlayerT.position);


		if (distance<walkingDistance)
		{ 

			transform.position = Vector3.SmoothDamp(transform.position, PlayerT.position, ref velocity, maxSpeed);

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
