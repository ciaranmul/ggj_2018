using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SliderMovement : MonoBehaviour {

    public float sliderValue = 0;

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

            if (position.x - 0.0002f > -1f)
            {
                position.x -= 0.02f;
                sliderValue = position.x;
                this.transform.position = position;
            }

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            if(position.x + 0.0002f < 1f)
            {
                position.x += 0.02f;
                sliderValue = position.x;
                this.transform.position = position;
            }
            
        }
     
    }


}

