using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {

    int timeDelay = 3;
    public GameObject BadGuy;

	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Spawn(){
        for (int i = 0; i < 5; i++){
            Instantiate(BadGuy, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeDelay);
        }
    }
}
