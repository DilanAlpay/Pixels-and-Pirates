using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "variables/Transform")]
public class TransformVar : ScriptableObject
{
    public Transform value;

    public void Set(Transform t)
    {
        value = t;
    }
}
