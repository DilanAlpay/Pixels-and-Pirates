using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEH_NAV_Chase : BEH_Navigator
{
    public float stopDistance = 0.1f;

    public override void Move()
    {
        if (Vector2.Distance(transform.position, target.position) < stopDistance)
        {
            body.velocity = Vector2.zero;
        }
        else
        {
            base.Move();
        }
    }
}
