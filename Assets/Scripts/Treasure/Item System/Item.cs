using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(menuName = "Objects/Items/Simple")]
public class Item : Treasure
{
    /// <summary>
    /// How long this item's effect lasts
    /// </summary>
    public float duration;

    /// <summary>
    /// How long, in seconds it takes to recharge
    /// </summary>
    public float recharge = 1;

    public EntityEvent onActivate, onUpdate, onFinish;

    /// <summary>
    /// Action when item is used
    /// </summary>
    /// <param name="player"></param>
    public virtual void Effect_Activate(Entity p, ItemInstance i)
    {
        onActivate.Invoke(p);
    }

    /// <summary>
    /// Action while item is in use
    /// </summary>
    /// <param name="player"></param>
    public virtual void Effect_Update(Entity p, ItemInstance i)
    {
        onUpdate.Invoke(p);
    }

    /// <summary>
    /// Action when item is finished
    /// </summary>
    /// <param name="player"></param>
    public virtual void Effect_Finish(Entity p, ItemInstance i)
    {
        onFinish.Invoke(p);
    }
  
    /// <summary>
    /// I want to keep this so we can override the method for specific items that do something
    /// potentially WACKY when they spawn something
    /// </summary>
    /// <param name="p"></param>
    /// <param name="effect"></param>
    /// <param name="parent"></param>
    public virtual void Spawn(Entity p, SpawnableEffect effect, bool parent)
    {
        Vector3 spot = p.transform.position + (p.offsetY * Vector3.up);
        SpawnableEffect spawnableEffect = Instantiate(effect, spot, Quaternion.identity);

        if (parent)
            spawnableEffect.transform.parent = p.transform;

        spawnableEffect.Spawn(p, this);        
    }
   

    public enum Status
    {
        NONE, READY, USING, CHARGING
    }
}

[System.Serializable]
public class ItemEvent : UnityEvent2<Player, ItemInstance> {}
