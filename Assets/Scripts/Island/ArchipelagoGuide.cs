using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/Archipelago Guide")]
public class ArchipelagoGuide : ScriptableObject
{
    public List<IslandInfo> islands;
    public TreasureList chests, challenge,shop,pet;
    public ObjList waves;
    public Spawner chestValuable;
    public TreasureSpawner chestTreasure;
    public ObjList enemies;


    public Treasure GetTreasure(PoolType ask)
    {
        switch (ask)
        {
            case PoolType.CHEST:
                return chests.GetRandom();
            case PoolType.SHOP:
                return shop.GetRandom();
            case PoolType.PET:
                return pet.GetRandom(); ;
            case PoolType.CAVE:
                return challenge.GetRandom();
            case PoolType.BOSS:
                return null; 
            default:
                return null;
        }
    }

    public IslandInfo GetIsland(IslandType ask, List<IslandInfo> chosen)
    {
        List<IslandInfo> options = new List<IslandInfo>();
        foreach (IslandInfo i in islands)
        {
            if (i.type==ask && !chosen.Contains(i))
            {
                options.Add(i);
            }          
        }
        return options.Count > 0 ? options[Random.Range(0, options.Count)] : null;
    }

    public int IslandCount()
    {
        return islands.Count;
    }

    public GameObject GetEnemy()
    {
        return enemies.GetRandom();
    } 
}
