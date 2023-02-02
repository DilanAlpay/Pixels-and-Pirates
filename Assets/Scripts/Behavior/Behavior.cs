using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    public bool allowed = true;
    protected Entity entity;

    public virtual void SetEntity(Entity e)
    {
        entity = e;
    }
    public virtual void Enable()
    {
        allowed = true;
    }

    public virtual void Disable()
    {
        allowed = false;         
    }
}
