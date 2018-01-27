using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordMovement : MonoBehaviour {

    float rotationSpeed;

    // Update is called once per frame
    void Update()
    {
        rotationSpeed = Time.deltaTime  * 100 * GameObject.Find("Slider").transform.localPosition.x;
        transform.Rotate(0, rotationSpeed, 0, Space.Self);
    }
}
