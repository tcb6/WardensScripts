using UnityEngine;
using System.Collections;

public class CharacterControllerLogic : MonoBehaviour {

	private Animator animator;

	private float speed = 0.0f;
	private float attack = 0.0f;
	public float playerSpeed = 2.0f;

	// Use this for initialization
	void Start () {

	animator = GetComponent<Animator>();

	if(animator.layerCount >= 2)
	{
		animator.SetLayerWeight(1, 1);
	}
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
		if(animator){
			if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) ){
				speed = 1.0f;
				animator.SetFloat("Speed", speed);
			}
			else{
				speed = 0.0f;
				animator.SetFloat("Speed", speed);
				}

			if(Input.GetMouseButtonDown(0)){
				attack = 1.0f;
				animator.SetFloat("Attacking", attack);
			}
			else{
				attack = 0.0f;
				animator.SetFloat("Attacking", attack);
			}

			if(speed > 0.5f){
				if(Input.GetKey(KeyCode.W)){
					animator.SetFloat("Direction", 1.0f);
					transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.A)){
					animator.SetFloat("Direction", 0.0f);
					transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.D)){
					animator.SetFloat("Direction", 0.5f);
					transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
				}
				if(Input.GetKey(KeyCode.S)){
					animator.SetFloat("Direction", -1.0f);
					transform.Translate(Vector3.back * playerSpeed * Time.deltaTime);
				}

			}

		}
	
	}
}
