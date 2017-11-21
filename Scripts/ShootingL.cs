using UnityEngine;
using System.Collections;

public class ShootingL : MonoBehaviour {


	public float fast;
	public GameObject bullet; 
	private GameObject bulletClone;
	private Rigidbody bulletPrefab;

	void Start (){

		fast = 500;
	}

	void Update () {

		if (Input.GetButtonDown("Fireleft")) 
		{
			bulletClone = Instantiate (bullet, transform.position, Quaternion.identity) as GameObject; 
			bulletPrefab = bulletClone.GetComponent<Rigidbody>(); 
			bulletPrefab.AddForce(transform.forward * fast);
		}
	}
}
