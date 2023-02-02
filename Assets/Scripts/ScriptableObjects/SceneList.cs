using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Lists/Scenes")]
public class SceneList : ScriptableObject
{
    public List<Object> contents;

    public Object Get(int i)
    {
        return contents[i];
    }

    public void Add(Object obj)
    {
        contents.Add(obj);
    }
}
