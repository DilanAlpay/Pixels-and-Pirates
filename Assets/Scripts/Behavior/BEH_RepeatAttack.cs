using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A Turret is an object that attacks a target when it is close enough
/// It will always shoot in any direction towards target
/// </summary>
public class BEH_RepeatAttack : Behavior
{  
    public Animator anim;
    public Transform pivot;
    public Weapon weapon;
    /// <summary>
    /// Useful for when an enemy has a weapon either to the left or the right
    /// </summary>
    public float angleOffset;
    public Vector2 dir;
    private WeaponInstance weaponInstance;
    public Transform target;
    public bool onStart = false;

    public override void SetEntity(Entity e)
    {
        base.SetEntity(e);
        weaponInstance = new WeaponInstance(entity, weapon);
        entity?.stats.Add(weaponInstance.stats);
        if (onStart)
        {
            StartAttack();
        }
    }

    private void Update()
    {
        if (!allowed || !target) return;
        AimAtTarget();
    }

    public void AimAtTarget()
    {
        Vector2 direction = (Vector2)target.position - (Vector2)transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        if (pivot)
        {
            pivot.rotation = Quaternion.Euler(Vector3.forward * (angle + angleOffset));
        }
    }

    public void SetTarget(Transform t)
    {
        target = t;
        StartAttack();
    }

    public void LoseTarget()
    {
        target = null;
        StopAttack();
    }

    public void StartAttack()
    {
        Invoke("Attack", Rate());
    }

    public void Attack()
    {
        if (!target && dir == Vector2.zero) return;

        if (anim)
        {
            anim.SetTrigger("Attack");
        }
        weaponInstance.Fire(transform, target ? (Vector2)(target.position - transform.position) : dir);
        Invoke("Attack", Rate());

    }

    public void StopAttack()
    {
        CancelInvoke();
    }

    public override void Enable()
    {
        base.Enable();
        if (target)
        {
            StartAttack();
        }
    }

    public override void Disable()
    {
        base.Disable();
        CancelInvoke();
    }

    public float Rate()
    {
        return (entity ? entity.stats.GetStat(Stat.RATE) : 0) + weaponInstance.Rate();
    }
}
