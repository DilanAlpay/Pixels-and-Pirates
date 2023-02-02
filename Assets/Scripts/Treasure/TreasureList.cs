using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lists/Treasures")]
public class TreasureList : ScriptableObject
{
    public List<Treasure> treasures;
   
    public Treasure GetRandom()
    {
        Treasure t = treasures[Random.Range(0, treasures.Count)];
        return t;
    }
}
