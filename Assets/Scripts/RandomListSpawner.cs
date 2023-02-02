using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomListSpawner : Spawner
{
    public ObjList options;
    
    
    public override void Spawn()
    {
        options.SpawnRandom((Vector2)transform.position + offset);
    }
}
