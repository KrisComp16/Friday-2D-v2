using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
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
    }



    void DoMove()
    {
        Vector2 velocity = rb.velocity;

     //   if( Helper.DoFaceLeft(player, true))
     //   {
     //       velocity.x = -5;
     //   }
    //    else 
     //   {
            
     //   }


        rb.velocity = velocity;
    }

}