using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Listener_Transform : ListenerBase<Transform>
{
    public UnityEvent_Transform myResponse;

    public override void Call(Transform obj)
    {
        response = myResponse;
        base.Call(obj);
    }
}


[System.Serializable]
public class UnityEvent_Transform : UnityEvent<Transform>
{

}