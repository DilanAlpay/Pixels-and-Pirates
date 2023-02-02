using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Diggable : MonoBehaviour
{
    public bool diggable = true;
    public GameEvent digEvent;

    public virtual void Dig()
    {
        if (diggable)
        {
          
            diggable = false;
            if (digEvent)
            {
                digEvent.Call(gameObject);
            }
            gameObject.SetActive(false);
        }        
    }
}
