using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorSE : MonoBehaviour
{

    public ParticleSystem ps;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        ps = GetComponent<ParticleSystem>();
        ps.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        DoSpecialEffectsAnim();
    }

    void DoSpecialEffectsAnim()
    {

        anim.SetBool("SpecEff", false);

        if (Input.GetKey("f"))
        {
            anim.SetBool("SpecEff", true);
        }

    }


    void DoSpecialEffects()
    {
        ps.Play();
    }

    void StopSpecialEffects()
    {
        ps.Stop();
    }

}
