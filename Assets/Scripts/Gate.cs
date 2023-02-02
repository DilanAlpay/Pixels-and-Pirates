using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
[RequireComponent(typeof(GameEventListener))]
public class Gate : MonoBehaviour
{
    public bool open = false;
    public int need;
    private int have = 0;
    public bool destroyAfter = true;
    public UnityEvent onOpen;
    
    public void Get()
    {
        if(!open)
        {
            have++;
            if (have >= need)
            {
                open = true;
                onOpen.Invoke();
                if (destroyAfter)
                {
                    Destroy(gameObject);
                }
            }
        }
       
    }
}
