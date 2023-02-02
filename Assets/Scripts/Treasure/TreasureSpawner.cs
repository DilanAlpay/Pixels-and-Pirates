using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Spawns a specific Treasure at this spot
/// Used by Chests
/// </summary>
public class TreasureSpawner : Spawner
{
    public TreasureObj obj;
    private Treasure treasure;

    public override void SetTreasure(Treasure t)
    {
        treasure = t;
    }    

    public override void Spawn()
    {
        TreasureObj newObj= Instantiate(obj, (Vector2)transform.position + offset, obj.transform.rotation);
        newObj.Set(treasure);
    }

}
