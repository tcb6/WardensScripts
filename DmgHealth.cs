using UnityEngine;
using System.Collections;

public class DmgHealth : MonoBehaviour {
    int hp, isDead, dmg;
	// Use this for initialization
	void Start () {
         hp = 3;
        isDead = 0;
	}
	
	// Update is called once per frame
	void Update () {
        dmg = Random.Range(1, 4);

        if (isDead == 1)
        {
            Destroy(gameObject);
        }
        if (hp == 0)
        {
            isDead = 1;
        }

        }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0)){

            hp--;// dmg;
        }
    }

}

