using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public Transform dest;
    public GameEvent enterEvent;
    public Collider confiner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = dest.position;
        enterEvent.Call(confiner);
    }
}
