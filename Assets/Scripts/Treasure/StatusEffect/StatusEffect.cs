using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/StatusEffect")]
public class StatusEffect : ScriptableObject
{
    public StatusObj effect;
    public EntityEvent onStart, onEnd;
}
