using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Objects/WeaponTagSet")]
public class WeaponTagSet : ScriptableObject
{
    public WeaponTag positive, negative;
    public Sprite icon;
}
