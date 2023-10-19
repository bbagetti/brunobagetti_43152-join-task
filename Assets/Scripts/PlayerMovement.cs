using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public int playerSpeed = 10;
    private bool facingRight = false;
    public int playerJumpPower = 1250;
    private float moveX;
    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    void PlayerMove() {
        //CONTROLS
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            Jump();
        }
        //PLAYER DIRECTION
        if(moveX < 0.0f && facingRight == false)
        {
            FlipPlayer();
        }
        else if(moveX > 0.0f && facingRight == true)
        {
            FlipPlayer();
        }
        //PHYSICS
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
    }

    void Jump()
    {
        //JUMPING
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
        isGrounded = false;
    }

    void FlipPlayer()
    {
        //FLIPPING PLAYER SIDE
        facingRight = !facingRight;
        Vector2 localScale = gameObject.transform.localScale;
        localScale.x *= -1;
        transform.localScale = localScale;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //ONLY JUMPS IF ON THE GROUND OR ENEMY
        if(col.gameObject.tag == "ground" || col.gameObject.tag == "Enemy")
        {
            isGrounded = true;
        }
    }
}
