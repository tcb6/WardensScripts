using UnityEngine;
using System.Collections;

public class EnemyAnimations : MonoBehaviour {

	private float distance;
	private bool isDead;
	Transform playerPos;

	private Animator animator;		//assign enemy animator here

	// Use this for initialization
	void Start () {
	isDead = false;

		animator = GetComponent<Animator>();

	if(animator.layerCount >= 2)
	{
		animator.SetLayerWeight(1, 1);
	}
	
	}
	
	// Update is called once per frame
	void Update () {
		distance = Vector3.Distance (this.transform.position, playerPos.position);

		if (distance < 1){
			animator.SetFloat("Distance", 0.0f);
		} else {
			animator.SetFloat("Distance", 1.0f);
		}

		if(isDead){
			animator.SetBool("isDead", true);
		}
	
	}
}
