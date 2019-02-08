using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

	public float distanceAway;
	private float constantDistanceAway;
	public float distanceUp;
	public float smooth;
	private Transform follow;
	private Vector3 targetPosition;

	// Use this for initialization
	void Start () {

		follow = GameObject.FindWithTag("CameraFollow").transform;
		constantDistanceAway = distanceAway;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate() {
		targetPosition = follow.position + follow.up * distanceUp - follow.forward * distanceAway; // Sets the target to follow

		transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * smooth); // Sets the camera position

		transform.LookAt(follow); // Makes camera look at player

		RaycastHit info;

		// Check for camera collision
		if( Physics.Raycast(follow.position, transform.position - follow.position, out info, distanceAway )){
			distanceAway = info.distance;
		}
		else{
			distanceAway = constantDistanceAway;
		}
	}
}
