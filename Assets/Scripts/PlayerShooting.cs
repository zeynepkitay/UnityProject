using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public Rigidbody bulletPrefab;
    public Transform firingPoint;
    public float bulletSpeed = 50f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

	}

    void Shoot()
    {
        Rigidbody bulletInstance = Instantiate(bulletPrefab, firingPoint.position, firingPoint.rotation) as Rigidbody;

        bulletInstance.velocity = bulletSpeed * firingPoint.forward;
    }
}
