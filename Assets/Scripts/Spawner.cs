using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Vector2 offset;

    public virtual void Spawn()
    {}

    public virtual void SetTreasure(Treasure t)
    {

    }
}
