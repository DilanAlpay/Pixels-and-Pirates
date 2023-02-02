using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HP_Player : HP
{
    private Player character;
    private void Start()
    {
        character = GetComponent<Player>();
    }
    public override void Hurt(float damage, WeaponInstance source)
    {
        Hurt(damage);
        //character.Trigger_Hurt(source);
    }
}
