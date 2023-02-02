using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomCluster : MonoBehaviour
{
    public ObjList options;
    public int min, max;

    void Start()
    {
        int count = Random.Range(min, max + 1);
        for (int i = 0; i < count; i++)
        {
            options.SpawnRandom(transform.position);
        }
        Destroy(gameObject);
    }
}
