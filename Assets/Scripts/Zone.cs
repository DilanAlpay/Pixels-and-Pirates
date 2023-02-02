using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Zone : MonoBehaviour
{
    public bool destroyAfter = false;
    public UnityEvent onEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        onEnter.Invoke();
        if (destroyAfter)
        {
            Destroy(gameObject);
        }
    }
}
