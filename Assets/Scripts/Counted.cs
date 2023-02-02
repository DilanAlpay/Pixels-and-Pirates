using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counted : MonoBehaviour
{
    public GameEvent myEvent;
    private void OnEnable()
    {
        myEvent.Call(gameObject);
        Destroy(this);
    }
}
