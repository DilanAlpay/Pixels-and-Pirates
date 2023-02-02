using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// HP is the script that handles 
/// the player's health
/// </summary>
public class HP : MonoBehaviour
{
    public float hp;
    public float max = 1;
    public float bonus = 0;

    /// <summary>
    /// How long the entity is invincible for
    /// </summary>
    public float inv;
    /// <summary>
    /// The time when we will be able to be hurt again
    /// </summary>
    private float invTime;

    //Tells us if we are invincible or not
    private bool invincible = false;
    public UnityEvent onhurt, ondeath;
    protected bool isDead = false;
    private float multiplier = 1;

    protected SpriteRenderer art;


    // Start is called before the first frame update
    void Awake()
    {
        hp = max;
        art = GetComponentInChildren<SpriteRenderer>();
    }

    public void Set(float h)
    {
        max = h;
        hp = max;
    }

    public void ChangeMax(float h)
    {
        max += h;
        hp = Mathf.Clamp(hp, 0, max);
    }

    public virtual void Hurt(float damage, GameObject source)
    {
        Hurt(damage);
    }

    public virtual void Hurt(float damage, Entity source)
    {
        Hurt(damage);
        source.TriggerOn(Trigger.HIT, GetComponent<Entity>());
        if (isDead)
        {
            source.TriggerOn(Trigger.KILL, GetComponent<Entity>());

        }
    }

    public virtual void Hurt(float damage, WeaponInstance source)
    {
        Hurt(damage);
        source.TriggerOn(Trigger.HIT,GetComponent<Entity>());
        if (isDead)
        {
            source.TriggerOn(Trigger.KILL, GetComponent<Entity>());
            
        }
    }



    public virtual void Hurt(float d)
    {
        if (invincible || invTime > Time.time) return;

        float damage = d * multiplier;

        //Find out how much damage was taken by the shield
        float healthDamage = Mathf.Clamp(damage - bonus, 0, damage);

        //Apply shield damage
        bonus = Mathf.Clamp(bonus - damage, 0, bonus);

        //We lose health based on the damage
        hp -= healthDamage;

        StartCoroutine(Flash());
        //check to see if we died
        if (hp <= 0) 
        {
            Death();
        }
        else
        {
            onhurt.Invoke();
            //otherwise, start being invincible
            invTime = Time.time+inv;

        }
    }

    public IEnumerator Flash()
    {
        art.color = Color.red;
        yield return new WaitForSeconds(.1f);
        art.color = Color.white;
    }

    public void Death()
    {
        isDead = true;
        if (ondeath.GetPersistentEventCount() > 0)
        {
            ondeath.Invoke();
        }
        else
        {
            Destroy();
        }
    }

    public void Heal(float h)
    {
        hp = Mathf.Clamp(hp + h, 0, max);
    }

    public void Restore()
    {
        invincible = false;
    }

    public void Bonus(float b)
    {
        bonus = Mathf.Clamp(bonus + b, 0, 20);
    }

    

    public void Increase(float i)
    {
        max += i;
        hp += i;
    }

    public void SetInvincible(bool i)
    {
        invincible = i;
    }

    public void Destroy()
    {
        Destroy(gameObject, .1f);
    }

    public float GetHP()
    {
        return hp;
    }

    public void ChangeMultiplier(float m)
    {
        multiplier += m;
    }
}
