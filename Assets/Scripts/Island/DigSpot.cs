using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigSpot : Diggable
{
    private DigInfo info;
    public Treasure treasure;
    public Spawner chest;

    public void SetInfo(DigInfo i)
    {
        info = i;
    }

    public void SetChest(Spawner c)
    {
        chest = c;
    }
    public void SetTreasure(Treasure t)
    {
        treasure = t;
    }

    public override void Dig()
    {
        if (diggable)
        {
            //digEvent.Call(info.chestIndex);
            Spawner myChest = Instantiate(chest, transform.position, Quaternion.identity);
            myChest.SetTreasure(treasure);
            gameObject.SetActive(false);
        }
    }
}
