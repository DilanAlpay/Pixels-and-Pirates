using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The actual in-game object that looks like a treasure
/// You are collecting THESE obejcts
/// </summary>
public class TreasureObj : MonoBehaviour
{
    public Treasure treasure;
    public GameEvent collected;
    protected SpriteRenderer display;
    private ItemInstance instance;

    void Awake()
    {
        display = GetComponent<SpriteRenderer>();
        if (treasure != null)
        {
           display.sprite = treasure.icon;
        }
    }

    public void Set(Treasure t)
    {
        display = GetComponent<SpriteRenderer>();
        treasure = t;
        display.sprite = treasure.icon;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (treasure.type == Treasure.Type.ITEM)
        {
            OnEnterItem(collision);
        }
        else
        {
            OnEnterTreasure(collision);
        }
    }

    public void OnEnterTreasure(Collider2D collider)
    {
        collected.Call((ScriptableObject)treasure);
        Destroy(gameObject);
    }

    public void OnEnterItem(Collider2D collider)
    {
        collected.Call();
        Player player = collider.GetComponent<Player>();
        ItemInstance oldItem = player.GetItem();
        //This is our first item
        if (oldItem == null)
        {
            player.SetItem((Item)treasure);
            Destroy(gameObject);
        }
        //This is not our first item
        else
        {
            //This ItemObj has been used once before
            if (instance != null)
            {
                player.SetItem(instance);
            }
            //This ItemObj has NOT been used before
            else
            {
                player.SetItem((Item)treasure);
            }

            instance = oldItem;
            display.sprite = instance.item.icon;
        }
    }
}
