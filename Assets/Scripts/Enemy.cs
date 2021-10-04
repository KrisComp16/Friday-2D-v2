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
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // DoMove();
        Helper.EnemyDirection( player, gameObject);
       // DoJump();

    }

    /*

    void DoMove()
    {
        Vector2 velocity = rb.velocity;

        float ex = transform.position.x;

        float px = player.transform.position.x;

        if (ex > px)
        {
            Helper.DoFaceLeft(gameObject, true);
            velocity.x = -2;
        }
        
        else if (ex == px)
        {
            Helper.DoFaceLeft(gameObject, false);
            velocity.x = 0;
        }
        
        
        else
        {
            Helper.DoFaceLeft(gameObject, false);
            velocity.x = -2;
        }


        rb.velocity = velocity;
    }
    */





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




    void DoThrow()
    {

    }

}