using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletConditions : MonoBehaviour {

    public float projectileSpeed = 5;


    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<Rigidbody>().velocity = transform.TransformDirection(new Vector3(-projectileSpeed * Mathf.Abs(GameObject.Find("Slider").transform.localPosition.x), 0, 0));
    }
}
