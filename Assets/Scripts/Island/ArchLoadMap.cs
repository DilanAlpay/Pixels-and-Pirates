using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A collection of flags used to keep track of which Islands we have spawned in
/// </summary>

public class ArchLoadMap
{
    private bool[,] flags;

    public ArchLoadMap (int c,int r)
    {
        flags = new bool[c, r];
    }

    public bool Visit(int c, int r)
    {
        bool b = flags[c, r];
        flags[c, r] = true;
        return b;
    }
}
