using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class SliderMovement : MonoBehaviour
{

    public float movementIncrement = 0.01f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Vector3 position = this.transform.position;


            if (this.transform.localPosition.x - movementIncrement > -1.5f)
            {
                position.x -= movementIncrement;
                this.transform.position = position;
            }

        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            Vector3 position = this.transform.position;
            if (this.transform.localPosition.x + movementIncrement < 1.5f)
            {
                position.x += movementIncrement;
                this.transform.position = position;
            }

        }

    }


}