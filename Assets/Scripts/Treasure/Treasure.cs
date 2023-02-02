using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[CreateAssetMenu(menuName = "Objects/Treasure")]
public class Treasure:ScriptableObject
{
    public Sprite icon;
    /// <summary>
    /// Number in the list of all treasures
    /// </summary>
    public int number;

    public Type type;
    /// <summary>
    /// All BASIC Stat boosts this treasure gives
    /// </summary>
    public Stats stats;

    /// <summary>
    /// Any and all abilities this gives the player
    /// </summary>
    public List<Ability> abilities;

    public EntityEvent onCollect;

    public void Collect(Player player)
    {
        player.stats.Add(stats);        
        if (stats.maxHealth != 0)
        {
            player.ChangeMaxHealth(stats.maxHealth);
        }

        onCollect.Invoke(player);
    }

    public enum Type
    {
        NULL,
        BOON, 
        ABILITY,
        ITEM
    }
}