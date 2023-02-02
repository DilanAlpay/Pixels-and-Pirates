using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public HP health;
    public Stats stats;
    public float offsetY;
    public List<Ability> abilities;
    public List<StatusEffect> effects;

    public virtual void Awake()
    {
        //Activate all abilities
        foreach (Ability ability in abilities)
        {
            ability.Trigger(Trigger.INSTANT, this, null);
        }

        if (health == null)
        {
            health = GetComponent<HP>();
        }
        //Set our maximum health
        health.Set(stats.maxHealth);
    }

    public void AddEffect(StatusEffect e, float duration)
    {
        if (effects.Contains(e)) return;

        effects.Add(e);
        StatusObj obj = Instantiate(e.effect, transform);
        obj.transform.localPosition = Vector3.zero;
        obj.Init(e);
        obj.EffectStart(this, duration);
    }

    public void RemoveEffect(StatusEffect e)
    {
        effects.Remove(e);
    }

    public HP GetHealth()
    {
        return health;
    }

    public void ChangeMaxHealth(float amount)
    {
        health.ChangeMax((int)amount);
    }

    public virtual bool IsMoving()
    {
        return true;
    }

    public virtual Vector2 GetDirection()
    {
        return Vector2.zero;
    }

    public void TriggerOn(Trigger trigger, Entity e)
    {
        foreach (Ability ability in abilities)
        {
            ability.Trigger(trigger, this, e);
        }
    }

    public void RefreshAbilities()
    {
        int x = 0;
        while (x<abilities.Count)
        {
            if (abilities[x].dead)
            {
                abilities.RemoveAt(x);
            }
            else
            {
                x++;
            }
        }
    }

    public float GetStat(Stat stat)
    {
        return stats.GetStat(stat);
    }
}
