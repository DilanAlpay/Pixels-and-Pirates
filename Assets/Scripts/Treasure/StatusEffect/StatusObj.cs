using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The StatusObj is the object attached to an enemy with a status
/// This is used to indicate the status the enemy has
/// ex: frozen effect on a Frozen enemy
/// </summary>
public class StatusObj : MonoBehaviour
{
    protected float duration;
    private StatusEffect effect;
    protected Entity entity;    

    public void Init(StatusEffect e)
    {
        effect = e;
    }

    public virtual void EffectStart(Entity e, float d)
    {
        entity = e;
        duration = d;
        effect.onStart.Invoke(entity);
        Invoke("EffectEnd", duration);
    }

    public virtual void EffectEnd()
    {
        entity.RemoveEffect(effect);
        effect.onEnd.Invoke(entity);
        Destroy(gameObject);
    }
}
