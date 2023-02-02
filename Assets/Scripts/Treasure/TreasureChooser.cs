using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Determines what type of treasure an in-level TreasureOBJ will hold
/// </summary>
public class TreasureChooser : MonoBehaviour
{
    public PoolType type;
    public List<TreasureObj> objs;

    // Start is called before the first frame update
    void Start()
    {
        List<Treasure> treasures = new List<Treasure>();
        foreach (TreasureObj obj in objs)
        {
            Treasure t;
            do
            {
                t = Archipelago.instance.guide.GetTreasure(type);
            } while (treasures.Contains(t));
           
            treasures.Add(t); 
            obj.Set(t);
        }
    }
}
