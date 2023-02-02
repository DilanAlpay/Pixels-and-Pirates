using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "variables/Bool")]
public class BoolVar : ScriptableObject
{
    public bool value;

    public void Set(bool v)
    {
        value = v;
    }
}
