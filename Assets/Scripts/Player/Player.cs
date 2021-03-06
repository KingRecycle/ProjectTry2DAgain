﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Controller2D))]
public class Player : MonoBehaviour {

    public float jumpHeight = 4;
    public float timeToJumpApex = 0.4f;
    float accelerationTimeAirborne = 0.3f;
    float accelerationTimeGrounded = 0.1f;

    float moveSpeed = 6;

    float gravity;
    float jumpVelocity;

    Vector3 velocity;
    float velocityXSmoothing;

    Controller2D controller;

    public FacingDirection facingDirection = FacingDirection.Right;

    public enum FacingDirection {
        Left = -1,
        Right = 1
    }
    
    // Use this for initialization
	void Start () {
        controller = GetComponent<Controller2D>();

        gravity = -(2 * jumpHeight) / Mathf.Pow(timeToJumpApex, 2);
        jumpVelocity = Mathf.Abs(gravity * timeToJumpApex);
	}
	
	// Update is called once per frame
	void Update () {

        if(controller.collisions.above || controller.collisions.below)
        {
            velocity.y = 0;
        }

        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        if (Input.GetKeyDown(KeyCode.Space) && controller.collisions.below)
        {
            velocity.y = jumpVelocity;
        }

        float targetVelocityX = velocity.x = input.x * moveSpeed;
        velocity.x = Mathf.SmoothDamp(velocity.x, targetVelocityX, ref velocityXSmoothing, (controller.collisions.below) ? accelerationTimeGrounded : accelerationTimeAirborne);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if ( velocity.x > 0 )
            facingDirection = FacingDirection.Right;

        if ( velocity.x < 0 )
            facingDirection = FacingDirection.Left;
	}
    

}
