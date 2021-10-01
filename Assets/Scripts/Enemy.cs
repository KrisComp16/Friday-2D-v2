using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DoMove();
       // DoJump();

    }

    void DoMove()
    {
        Vector2 velocity = rb.velocity;

        float ex = transform.position.x;

        float px = player.transform.position.x;

        if (ex > px)
        {
            DoFaceLeft(true);
            velocity.x = -2;
        }
        
        else if (ex == px)
        {
            DoFaceLeft(false);
            velocity.x = 0;
        }
        
        
        else
        {
            DoFaceLeft(false);
            velocity.x = 2;
        }


        rb.velocity = velocity;
    }



    void DoJump()
    {
        Vector2 velocity = rb.velocity;

        float ey = transform.position.y;

        float py = player.transform.position.y;

        if (ey < py)
        {

            if (velocity.y < 0.01f)
            {
                velocity.y = 8f;    // give the player a velocity of 5 in the y axis

            }
        }
      
        rb.velocity = velocity;
    }


        void DoFaceLeft(bool faceleft)
    {
        if (faceleft == true)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }



    void DoThrow()
    {

    }

}