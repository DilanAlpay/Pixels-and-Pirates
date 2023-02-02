using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "variables/Int")]
public class IntVar : ScriptableObject
{
    public int value;

    public void Add(int i)
    {
        value += i;
    }
}
