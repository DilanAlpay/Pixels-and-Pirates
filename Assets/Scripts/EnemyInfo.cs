using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Enemy Info")]
public class EnemyInfo : ScriptableObject
{
    public GameObject prefab;
    public Stats stats;   
}
