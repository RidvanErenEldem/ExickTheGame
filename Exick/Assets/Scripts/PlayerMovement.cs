using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float bestJumpPower = 7f;
    public float jumpPower;

    public bool doubleJump;
    
    public int canJump;
    public Rigidbody2D pRb;

    private float moveIn;

    Animator animator;
    
    SpriteRenderer sprite;
    void Start()
    {
        pRb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        moveIn = Input.GetAxis("Horizontal");
        pRb.velocity = new Vector2(moveIn * speed, pRb.velocity.y);
        Flip();
        
        animator.SetFloat("Speed",  Mathf.Abs(moveIn)); //math.Abs mutlak değer aldık "-" değer olmasını engelledik.
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }

        if(pRb.velocity.y < 0) //Aşağı düşüyosa
        {
            pRb.velocity +=  Vector2.up * Physics2D.gravity.y * (bestJumpPower - 1) * Time.deltaTime;
        }
       
        else if(pRb.velocity.y > 0 && !Input.GetKey(KeyCode.Space))
        {
            pRb.velocity +=  Vector2.up * Physics2D.gravity.y * (bestJumpPower - 1) * Time.deltaTime;
        }

    }


    
    private void jump()
    {
        if(canJump > 0)
        {
          pRb.velocity = new Vector2(pRb.velocity.x,    jumpPower);
          canJump = canJump - 1;
        }

    }

    private void OnTriggerEnter2D()
    {
        animator.SetBool("IsGrounded",  true);
    }

    private void OnTriggerExit2D()
    {
        animator.SetBool("IsGrounded",  false);
    }

    private void Flip()
    {
        if(moveIn > 0)
        {
            sprite.flipX = false;
        }
        else if(moveIn < 0)
        {
            sprite.flipX = true;
        }
    }
    
}
