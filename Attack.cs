using UnityEngine;
using System.Collections;


public class Attack : MonoBehaviour {
	public int PHp, EHp, PDmg, EDmg;
	private int isDead;
	private bool attacking;
	public float attRange;
	private GameObject target;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update ()  {  

		if (isDead == 1)
		{
			Destroy(gameObject);
		}
		if (PHp == 0 && EHp == 0)
		{
			isDead = 1;
		}

		RaycastHit hit;
		Ray attackingRay1 = new Ray (transform.position + transform.up * .5f, Vector3.left);
		//Ray attackingRay2 = new Ray (transform.position, Vector3.left);
		//Ray attackingRay3 = new Ray (transform.position, Vector3.left);


		if (Input.GetMouseButtonDown (0)) {
			attacking = true;
		} else
			attacking = false;
		if (attacking) {
			Debug.DrawRay (transform.position + transform.up * .5f, Vector3.left * attRange);
			if (Physics.Raycast (attackingRay1, out hit, attRange)) {
				if (hit.collider != null) {
					hit.transform.SendMessage ("HitByRay");
					//target = hit.collider.gameObject;
					print ("Hit: " + hit.collider.gameObject.name); //Strike(); 
					EHp--;
				}
			}
		}
	}


	void HitByRay () {
		EHp--;
	}


	void Strike()
	{


		EHp--;
		//Deal DMG to the target object?


	}
}
