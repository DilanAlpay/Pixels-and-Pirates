using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lists/Objects")]
public class ObjList : ScriptableObject
{
    public List<GameObject> contents;

    public int Count { get { return contents.Count; } }

    public GameObject Get(int i)
    {
        return contents[i];
    }

    public GameObject GetRandom()
    {
        //return contents[0];
        return contents[Random.Range(0, contents.Count)];
    } 


    public void SpawnRandom(Vector3 position)
    {
        int r = Random.Range(0, contents.Count);
        if (contents[r] != null)
        {
            Instantiate(contents[r], position, Quaternion.identity);

        }
    }
}
