using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A weapon generated using a weapon as a base and adding on WeaponTags
/// </summary>
[System.Serializable]
public class WeaponInstance
{
    public Entity owner;
    public Weapon weapon;
    public Stats stats;

    public float scale      { get { return (owner ? owner.stats.scale   : stats.scale ); } }
    public float dist       { get { return (owner ? owner.stats.dist    : stats.dist ); } }
    public float power      { get { return (owner ? owner.stats.power   : stats.power); } }
    public float rate       { get { return (owner ? owner.stats.rate    : stats.rate ); } }
    public float bSpeed     { get { return (owner ? owner.stats.bSpeed  : stats.bSpeed); } }

    public List<WeaponTag> tags = new List<WeaponTag>();

    public WeaponInstance(Entity o, Weapon w)
    {
        owner = o;
        weapon = w;
        stats = new Stats(weapon.stats);
    }

    public WeaponInstance(Entity o, Weapon w, List<WeaponTag> newTags)
    {
        owner = o;
        weapon = w;
        stats = new Stats(weapon.stats);
        foreach (WeaponTag tag in newTags)
        {
            AddTag(tag);
        }
    }

    public void AddTag(WeaponTag tag)
    {
        tags.Add(tag);
        stats.MultiplyStat(tag.stat, tag.multiplier);
    }

    /// <summary>
    /// Attacks in a specific direction at a specific point
    /// </summary>
    /// <param name="spawnPoint"></param>
    /// <param name="dir"></param>
    public void Fire(Vector3 spawnPoint, Vector2 dir)
    {
        weapon.Attack(spawnPoint, dir, this);
    }

    /// <summary>
    /// Attacks in a specific direction from the transform's position
    /// </summary>
    /// <param name="transform"></param>
    /// <param name="dir"></param>
    public void Fire(Transform transform, Vector2 dir)
    {
        Fire(transform.position, dir);
    }

    public float Rate()
    {
        return stats.rate;
    }

    public Sprite Sprite()
    {
        return weapon.handSprite;
    }

    public WeaponType Type()
    {
        return weapon.type;
    }

    /// <summary>
    /// We have hit something
    /// </summary>
    /// <param name="hit"></param>
    public void TriggerOn(Trigger trigger, Entity hit)
    {
        weapon.ability?.Trigger(trigger, owner, hit);
        owner.TriggerOn(trigger, hit);
    }
}
