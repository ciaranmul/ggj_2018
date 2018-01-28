using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public Rigidbody projectile;

    public float fireRate;
    private float nextFire = 0.0F;


    void Fire()
    {
        Rigidbody bulletClone = (Rigidbody)Instantiate(projectile, new Vector3(this.transform.position.x-0.5f, this.transform.transform.position.y, this.transform.position.z), transform.rotation);
    }

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        

        if (Time.time > nextFire)
        {
      nextFire = Time.time + fireRate;
        Fire();
        }



    }
}
