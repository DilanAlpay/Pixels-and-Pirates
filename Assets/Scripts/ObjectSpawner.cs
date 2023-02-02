using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject obj;
    public Vector2 offset;

    public void SetObject(GameObject o)
    {
        obj = o;
    }
    public void Spawn()
    {
        Instantiate(obj, transform.position + (Vector3)offset, obj.transform.rotation);
    }
}
