using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///The behavior of any object that moves relative to a target
///If it does not need a target, then it ain't a navigator!
/// </summary>
public class BEH_Navigator : Behavior
{
    public Transform geo;

    protected Transform target;
    protected Rigidbody2D body;
    protected bool knocked = false;
    protected float knockEnd = 0;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (!allowed) return;
        if (knocked && Time.time > knockEnd)    knocked = false;

        if (target && !knocked)
        {
            Move();
        }

    }

    public virtual Vector2 Navigate ()
    {
        return target ? (Vector2) (target.position - transform.position) : Vector2.zero;
    }

    public virtual void Move()
    {
        //if our entity is not null, then we use entity.stats.move, or else we will use 0
        float curSpd = entity ? entity.stats.move : 0;
        Vector2 curDir = Navigate();

        body.velocity = curDir.normalized * curSpd;
    }

    public void SetTarget(Entity t)
    {
        target = t.transform;
    }

    public void SetTarget(Transform t)
    {
        target = t;
    }

    public void Knockback(Vector2 dir)
    {
        knocked = true;
        //For now, the knock duration will always be one second
        knockEnd = Time.time + 1;

        body.AddForce(dir,ForceMode2D.Impulse);
    }

    private void OnDisable()
    {
        body.velocity = Vector2.zero;
    }
}
