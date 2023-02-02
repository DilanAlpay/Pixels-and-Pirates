using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Ability")]
public class Ability : ScriptableObject
{
    public Trigger trigger;
    public Target target;
    [Range(1, 100)]
    public int chance;
    public EntityEvent onTrigger;
    public bool dead = false;
    
    protected bool WrongTrigger(Trigger t) { return trigger != t; }

    public virtual void Trigger(Trigger t, Entity self)
    {
        if (WrongTrigger(t)) return;
        onTrigger.Invoke(self);
    }

    public virtual void Trigger(Trigger t, Entity self, Entity them)
    {
        if (WrongTrigger(t)) return;

        switch (target)
        {
            case Target.NONE: onTrigger.Invoke(null); break;
            case Target.SELF: onTrigger.Invoke(self); break;
            case Target.THEM: onTrigger.Invoke(them); break;
        }
    }

    public void Kill()
    {
        dead = true;
    }
}

public enum Trigger
{
    NONE,
    UPDATE,
    INSTANT,
    HURT,   //I was hurt
    HIT,    //I hit something
    KILL,
    NEWISLAND,
    LEAVE
}
public enum Target
{
    NONE, SELF, THEM
}
