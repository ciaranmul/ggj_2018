using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordMovement : MonoBehaviour {

    float rotationSpeed;
    SliderMovement sliderScript;
    GameObject slider;

    // Use this for initialization
    void Start () {
        GameObject slider = GameObject.Find("Slider");
        SliderMovement sliderScript = slider.GetComponent<SliderMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        rotationSpeed = Time.deltaTime  * 100 * GameObject.Find("Slider").GetComponent<SliderMovement>().sliderValue;
        transform.Rotate(0, rotationSpeed, 0, Space.Self);
    }
}
