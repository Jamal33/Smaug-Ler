using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    private float playerVelocity;

    public PlayerController(float playerVelocity)
    {
        this.playerVelocity = playerVelocity;
    }

    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        // input
        float horizontalInput = Input.GetAxis("Horizontal");
        
        //speed
        Vector2 velocity = new Vector2(horizontalInput * playerVelocity, 0);
        velocity.y = rigidBody2D.velocity.y; //keep value given by physics
        rigidBody2D.velocity = velocity;
        //flip the sprite horizontally, depending on the move direction
        Vector3 scale = transform.localScale;
        if (velocity.x > 0)
        {
            scale.x = -Mathf.Abs(scale.x);
        }
        else if (velocity.x < 0)
        {
            scale.x = Mathf.Abs(scale.x);
        }
        transform.localScale = scale;

    }
}