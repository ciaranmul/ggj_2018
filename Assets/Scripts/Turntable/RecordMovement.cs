using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordMovement : MonoBehaviour {

    float rotationSpeed;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        rotationSpeed = Time.deltaTime * 30;
        transform.Rotate(0, rotationSpeed, 0, Space.Self);
    }
}
