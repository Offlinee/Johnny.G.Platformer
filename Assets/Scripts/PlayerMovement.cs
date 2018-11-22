using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed;
    public float jumpHeight;

    public GroundCheck groundCheck;

    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
            
      rbody.velocity = new Vector2(moveSpeed * Input.GetAxis("Horizontal"), rbody.velocity.y);

    if (Input.GetKeyDown(KeyCode.W) && groundCheck.touches > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
        if (Input.GetKeyDown(KeyCode.Space) && groundCheck.touches > 0)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
    }
    
        
}