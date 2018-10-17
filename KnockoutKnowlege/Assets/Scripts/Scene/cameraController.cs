using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
	// public GameObject player;

	// private Vector3 offset;
	// // Use this for initialization
	// void Start () {
	// 	offset = transform.position - player.transform.position;
	// }

	// // Update is called once per frame
	// void LateUpdate () {
	// 	transform.position = player.transform.position + offset;
	// }

	public Transform target;
	public float smoothSpeed = 0.125f;
	public Vector3 offset;

	void FixedUpdate ()
	{
		Vector3 desiredPosition = target.position + offset;
		desiredPosition.y = 0;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;
	}

}
