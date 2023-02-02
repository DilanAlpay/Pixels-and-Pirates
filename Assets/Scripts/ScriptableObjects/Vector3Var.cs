using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName ="variables/vector3")]
public class Vector3Var : ScriptableObject
{
    public Vector3 value;


    public void Set(Transform v)
    {
        value = v.position;
    }
}
