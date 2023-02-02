using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Parrot :Item
{
    public GameObject parrot;

    public float near, far, veryFar;
    public LayerMask targets;

    /*
    public override void Effect_Activate(Player player)
    {       
        GameObject copy = Instantiate(parrot, player.GetGEO());
        copy.transform.localPosition = Vector3.zero;
        copy.transform.localEulerAngles = Vector3.zero;
    }

    public override void Effect_Update(Player player)
    {
        /*
        Animator anim = copy.GetComponent<Animator>();
        
        if (Physics2D.OverlapCircle(player.transform.position, near, targets))
        {
            anim.SetInteger("level", 3);
        }
        else if (Physics2D.OverlapCircle(player.transform.position, far, targets))
        {
            anim.SetInteger("level", 2);
        }
        else if (Physics2D.OverlapCircle(player.transform.position, veryFar, targets))
        {
            anim.SetInteger("level", 1);
        }
        else
        {
            anim.SetInteger("level", 0);
        }
    }
    */
}
