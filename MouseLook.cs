using UnityEngine;
using System.Collections;

public class MouseLook : MonoBehaviour {

	public float sensitivityX = 15f;

	// Use this for initialization
	void Start () {

		// Make the rigid body not change rotation
		if (GetComponent<Rigidbody>())
			GetComponent<Rigidbody>().freezeRotation = true;

	
	}
	
	// Update is called once per frame
	void Update () {

		// Move the character on the x axis.
		transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivityX, 0);
	
	}
}
