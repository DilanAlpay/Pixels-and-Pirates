using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : ScriptableObject
{
    /// <summary>
    /// Icon showed in UI
    /// </summary>
    public Sprite icon;
   
    public Stats stats;

    public WeaponType type;

    /// <summary>
    /// The object that is put in the user's hand
    /// </summary>
    public Sprite handSprite;

    public Ability ability;
    
    public virtual void Attack(Vector3 spawnPoint, Vector2 dir, WeaponInstance instance)
    {
    }    
}


public enum WeaponType
{
    NULL, melee, ranged  
}
