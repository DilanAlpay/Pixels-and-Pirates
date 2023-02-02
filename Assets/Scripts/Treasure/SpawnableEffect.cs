using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class SpawnableEffect : MonoBehaviour
{
    private Entity owner;
    public EntityEvent onSpawn;

    public virtual void Spawn(Entity e, Item i)
    {
        owner = e;

        if (i.duration > 0)
            Destroy(gameObject, i.duration);

        onSpawn.Invoke(e);
    }

    public virtual void Spawn()
    {

    }

    public virtual void Spawn(Entity e,float duration)
    {
        owner = e;
        if (duration > 0)
        {
            Destroy(gameObject, duration);
        }
        onSpawn.Invoke(e);
    }

    public void Repeat()
    {
        onSpawn.Invoke(owner);

    }
}
