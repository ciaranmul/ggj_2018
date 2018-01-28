using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Rigidbody projectile;

    public float fireRate;
    private float nextFire = 0.0F;


    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(projectile, this.transform.position, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {

        if (Time.time > nextFire){
            nextFire = Time.time + fireRate;
            Fire();
        }



    }
}
