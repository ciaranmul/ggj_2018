using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SliderMovement : MonoBehaviour {


    Vector3 newPosition;
    void Start()
    {
        newPosition = transform.position;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;
            position.x -= 0.002f;
            this.transform.position = position;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            position.x += 0.002f;
            this.transform.position = position;
        }
     
    }


}

