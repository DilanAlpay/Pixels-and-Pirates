using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Togglable : MonoBehaviour
{
    public List<MonoBehaviour> behaviors;
    public List<GameObject> objects;
    public void Toggle()
    {
        foreach (MonoBehaviour behavior in behaviors)
        {
            behavior.enabled = !behavior.enabled;
        }

        foreach (GameObject obj in objects)
        {
            obj.SetActive(!obj.activeSelf);
            
        }
    }
}
