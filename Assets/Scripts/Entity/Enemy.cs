using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public List<Behavior> behaviors;
    //public Weapon weapon;
    //private WeaponInstance weaponInstance;

    private void Start()
    {
        Behavior[] found = gameObject.GetComponents<Behavior>();
        foreach (Behavior b in found)
        {
            behaviors.Add(b);
            b.SetEntity(this);
        }
        //weaponInstance = new WeaponInstance(this, weapon);
    }

    public void SetEnable(bool e)
    {
        if (e)
        {
            Enable();
        }
        else
        {
            Disable();
        }
    }

    public void Enable()
    {
        foreach (Behavior b in behaviors)
        {
            b.Enable();
        }
    }

    public void Disable()
    {
        foreach (Behavior b in behaviors)
        {
            b.Disable();
        }        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<HP>()?.Hurt(stats.power, this);
    }
}
