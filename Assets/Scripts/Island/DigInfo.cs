using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class DigInfo
{

    public int x, y;    //Where we are on the island's grid
    public bool hidden = false;
    public bool dug = false;        //If we have been dug up yet

    public DigInfo(Vector2Int p, bool h, bool d)
    {
        x = p.x;
        y = p.y;
        hidden = h;
        dug = d;
    }
}
