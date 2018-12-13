using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUpAndDownMovement : MonoBehaviour
{
    public float moveSpeed = 2f;
    public bool isUp = true;

    private Rigidbody2D rbody;
    
    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        Move(false);
    }
    // att man vänder när man går in i "InvisibleWall" och gör att objectet med detta script rör sig konstant ått höger ellerr vänster

    void Move(bool flip = true)
    {
        isUp = !isUp;
      
        if (isUp == true)
        {
            rbody.velocity = new Vector2(rbody.velocity.x, -moveSpeed);
          
        }
        else
        {
            rbody.velocity = new Vector2(rbody.velocity.x, moveSpeed);
        
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisibleWall")
        {
            Move(true);
        }
    }
}
