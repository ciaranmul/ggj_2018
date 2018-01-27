using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2d))]
public class Player : MonoBehaviour {

    Controller2d controller;

    Vector3 velocity;
    public float moveSpeed = 10;
    public float gravity = -20;
    public float jumpVelocity = 10;

	// Use this for initialization
	void Start () {
        controller = GetComponent<Controller2d>();
        velocity.x = Mathf.Clamp(0, -10, 10);
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

        velocity.x += input.x * moveSpeed;
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
	}
}
