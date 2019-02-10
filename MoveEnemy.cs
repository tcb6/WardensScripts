using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour
{

    public Transform goal;
	public GameObject playerObj;	// The player object
	GameObject temp;				// Temp variable
	Transform playerPos;			// The positiion of the player

	NavMeshAgent agent;

    void Start()
    {
		playerPos = playerObj.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.position;
    }

	void Update(){
		temp = GameObject.Find ("Player");
		playerPos = temp.GetComponent<Transform>();

		if (Vector3.Distance (this.transform.position, playerPos.position) < 2) {
			agent.destination = playerPos.position;
		}
	}
}