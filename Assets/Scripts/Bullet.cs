using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Enemy")
        {
            Destroy(gameObject);
        }

        else
        {
            EnemyHealth eh = other.GetComponent<EnemyHealth>();
            eh.Death();
            Destroy(gameObject);
        }
    }
}
