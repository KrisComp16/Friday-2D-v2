


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D rb;
    bool isGrounded;
    private Animator anim;
    public GameObject fireball;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        DoJump();
        DoMove();
        DoAttack();
        //DoShoot();
    }






    void DoJump()
    {
        Vector2 velocity = rb.velocity;

        // check for jump
        if (Input.GetKey("w") && (isGrounded == true))
        {
            if (velocity.y < 0.01f)
            {
                velocity.y = 8f;    // give the player a velocity of 5 in the y axis

            }
        }

        if (velocity.y != 0)
        {
            anim.SetBool("Jump", true);
        }
        else
        {
            anim.SetBool("Jump", false);
        }

        rb.velocity = velocity;

    }

    void DoMove()
    {
        Vector2 velocity = rb.velocity;

        // stop player sliding when not pressing left or right
        velocity.x = 0;

        // check for moving left
        if (Input.GetKey("a"))
        {
            velocity.x = -5;
        }

        // check for moving right
        if (Input.GetKey("d"))
        {
            velocity.x = 5;
        }

        anim.SetBool("Walking", false);


        if (velocity.x != 0)
        {
            anim.SetBool("Walking", true);
        }
        else
        {
            anim.SetBool("Walking", false);
        }

        if( velocity.x < -0.5f )
        {
            Helper.DoFaceLeft(gameObject, true);
            
            
        }
        if (velocity.x > 0.5f)
        {
            Helper.DoFaceLeft(gameObject,false);
        }


        rb.velocity = velocity;

    }

    private void OnCollisionStay2D(Collision2D collosion)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGrounded = false;
    }

    



    void DoAttack()
    {

        if (Input.GetKey("v"))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }


    }

    /*
    void DoShoot()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(fireball, transform.position, transform.rotation);
        }

    }
    */
}