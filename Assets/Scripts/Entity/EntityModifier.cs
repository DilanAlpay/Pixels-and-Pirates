using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Managers/EntityModifier")]
public class EntityModifier : ScriptableObject
{
    /* Basic ways we can change the Player or an enemy
     * Change speed (faster or slower)
     * Change health (damage or healing)
     * Change wpn rate
     * wpn speed
     * wpn size
     * wpn dmg
     * 
     */

    #region Stat Editing
    public virtual void SetInvincible(Entity entity,bool i)
    {
        entity.GetHealth()?.SetInvincible(i);
    }

    public virtual void Heal(Entity entity, int i)
    {
        entity.GetHealth().Heal(i);
    }
    #endregion

    #region Instantiating
    public virtual void Spawn(Entity p, SpawnableEffect effect, float duration, bool parent)
    {
        Vector3 spot = p.transform.position + (p.offsetY * Vector3.up);
        SpawnableEffect spawnableEffect = Instantiate(effect, spot, Quaternion.identity);

        if (parent)
            spawnableEffect.transform.parent = p.transform;

        spawnableEffect.Spawn(p, duration);
    }
    #endregion

    #region Modifiers
    public void AddAbility(Entity entity,Ability ability)
    {
        entity.abilities.Add(ability);
    }

    public void AddEffect(Entity entity, StatusEffect statusEffect,float duration)
    {
        entity.AddEffect(statusEffect, duration);
    }

    /// <summary>
    /// Gives you a damage modifier, increasing or decreasing damage taken
    /// </summary>
    /// <param name="entity"></param>
    /// <param name="m"></param>
    public void ModDamage(Entity entity,float m)
    {
        entity.health.ChangeMultiplier(m);
    }

    public void SetEnemyEnable(Entity entity,bool e)
    {
        entity.GetComponent<Enemy>()?.SetEnable(e);
    }

    public void ChangeStat(Entity entity,Stat stat,float amount)
    {
        entity.stats.AddStat(stat, amount);
    }
    
    #endregion
}
