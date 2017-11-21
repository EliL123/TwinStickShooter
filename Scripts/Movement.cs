using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	public float speed; 
	private Rigidbody RB;

	void Start (){
		RB = GetComponent<Rigidbody>();
		speed = 0.15f;
	}

	void Update () {
	
		float horizontalMove = Input.GetAxis ("Horizontal");
		float verticalMove = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (horizontalMove, 0.0f, verticalMove);
		RB.transform.Translate (movement*speed);
	}

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Out of Bounds")){

			gameObject.SetActive(false);
		}

	}
}
