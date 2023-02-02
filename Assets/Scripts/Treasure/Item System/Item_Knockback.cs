using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Knockback : Item
{
    public float radius;
    public float force;
    public LayerMask targets;

    /*
    public override void Effect_Activate(Player player)
    {
        base.Effect_Activate(player);
        Collider2D[] hits = Physics2D.OverlapCircleAll(player.transform.position, radius,targets);
        foreach (Collider2D hit in hits)
        {
            hit.GetComponent<Navigator>()?.Knockback((hit.transform.position - player.transform.position).normalized * force );
        }
    }
    */
}
