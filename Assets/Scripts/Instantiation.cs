using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiation : MonoBehaviour
{
    public GameObject fireball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DoShoot();
    }






    void DoShoot()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Instantiate(fireball, transform.position, transform.rotation);
        }

    }
}
