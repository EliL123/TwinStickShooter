using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {

	public GameObject Ethan;

	private Vector3 offset;

		void Start ()
		{
			offset = transform.position - Ethan.transform.position;
		}

		void Update ()
		{
			transform.position = Ethan.transform.position + offset;
		}
	}
