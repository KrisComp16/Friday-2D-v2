using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Globals;

public class Enemy : MonoBehaviour
{

    private Rigidbody2D rb;
    public GameObject player;
    public GameObject spear;
    public Transform firepoint;
    public GameObject collectible;

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
        print("Throw");
       
        
        if (Helper.GetDirection(gameObject) == true)
        {
            MakeBullet(spear, firepoint.position.x, firepoint.position.y, -6, 0);
        }
        else
        {
            MakeBullet(spear, firepoint.position.x, firepoint.position.y, 6, 0);
        }
    }

    void MakeBullet(GameObject prefab, float xpos, float ypos, float xvel, float yvel)
    {
        GameObject instance = Instantiate(prefab, new Vector3(xpos, ypos, 0), Quaternion.identity);

        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector3(xvel, yvel, 0);



    }

    void DropCollectible(GameObject prefab, float xpos, float ypos)
    {
        GameObject instance = Instantiate(prefab, new Vector3(xpos, ypos, 0), Quaternion.identity);
    }

    void OnTriggerEnter2D( Collider2D other)
    {
        print("tag=" + gameObject.tag);

        if (other.gameObject.tag == "Fireball")
        {
            print("I've been hit by a fireball!");
            Destroy(this.gameObject);
            Destroy(gameObject);
            DropCollectible(collectible, firepoint.position.x, firepoint.position.y);
        }
    }


}