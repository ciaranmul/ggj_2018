using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2d))]
public class Player : MonoBehaviour {

    Controller2d controller;

    public float jumpHeight = 4f;
    public float timeToJumpApex = .2f;

    public float maxPlayerSpeed = 10;

    Vector3 velocity;
    public int tempoInc = 2;
    float gravity;
    float jumpVelocity;

	// Use this for initialization
	void Start () {
        controller = GetComponent<Controller2d>();
        //velocity.x = Mathf.Clamp(0, -6, 6);
        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex,2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        if(Input.GetKeyDown(KeyCode.Space) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }

        //if(Mathf.Abs(velocity.x) < maxPlayerSpeed)
            velocity.x = maxPlayerSpeed * GameObject.Find("Slider").transform.localPosition.x;

        print("velocity.x = " + velocity.x);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
	}

}
