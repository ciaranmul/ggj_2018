using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Controller2d))]
public class Player : MonoBehaviour {

    Controller2d controller;

    public float jumpHeight = 4f;
    public float timeToJumpApex = .2f;

    public float maxPlayerSpeed = 15;

    Vector3 velocity;
    public int tempoInc = 2;
    float gravity;
    float jumpVelocity;

    Animator animator;

    // Use this for initialization
    void Start () {
        controller = GetComponent<Controller2d>();
        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex,2);
        jumpVelocity = Mathf.Abs(gravity) * timeToJumpApex;
        animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        //Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if(controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        
        if(controller.collisions.below)
        { 
            animator.SetBool("jumping", false);
            if (Input.GetKeyDown(KeyCode.Space))
            {
                velocity.y = jumpVelocity;
                GameObject.Find("Jump").GetComponent<AudioSource>().Play();
                animator.SetBool("jumping", true);
                animator.SetBool("running", false);
                animator.speed = 1;

                GameObject.Find("Startle").GetComponent<ParticleSystem>().Play();
            }
        }

        velocity.x = maxPlayerSpeed * GameObject.Find("Slider").transform.localPosition.x;

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        UpdateAnimation();
	}

    void UpdateAnimation()
    {
        if (Mathf.Abs(velocity.x) > 1 && controller.collisions.below)
        {
            animator.SetBool("running", true);
            animator.speed = Mathf.Abs(GameObject.Find("Slider").transform.localPosition.x);
        }
        else
        {
            animator.SetBool("running", false);
        }
        
    }

}
