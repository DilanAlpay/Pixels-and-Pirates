using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemInstance
{
    public Item item;

    /// <summary>
    /// Time when this item will change its status
    /// </summary>
    private float endTime;

    /// <summary>
    /// Who is using this item
    /// </summary>
    protected Player player;

    /// <summary>
    /// True if this item is ready to be used again
    /// </summary>
    public Item.Status status = Item.Status.READY;

    public float duration { get { return item.duration; } }

    public ItemInstance(Item i, Player p)
    {
        item = i;
        player = p;
        status = Item.Status.READY;        
    }

    public virtual void Activate()
    {
        if (status == Item.Status.READY)
        {
            endTime = Time.time + item.duration;
            status = Item.Status.USING;
            item.Effect_Activate(player, this);
        }
    }

    public virtual void Update()
    {
        if (CheckStatus(Item.Status.USING))
        {
            if (Time.time < endTime)
            {
                item.Effect_Update(player, this);
            }
            else
            {
                Finish();
            }
        }
        else if(CheckStatus(Item.Status.CHARGING) && Time.time >= endTime)
        {
            ReadyAgain();
        }
    }
    public void Finish()
    {
        if (CheckStatus(Item.Status.USING))
        {
            item.Effect_Finish(player, this);
            Recharge();
        }
    }

    public void Recharge()
    {
        //Start charging now
        endTime = Time.time + item.recharge;
        status = Item.Status.CHARGING;
    }

    public void ReadyAgain()
    {
        status = Item.Status.READY;
    }

    public bool CheckStatus(Item.Status s)
    {
        return status == s;
    }

    /// <summary>
    /// Returns what time this item will be done or recharged
    /// </summary>
    /// <returns></returns>
    public float GetTime()
    {
        return endTime;
    }    

    
}
