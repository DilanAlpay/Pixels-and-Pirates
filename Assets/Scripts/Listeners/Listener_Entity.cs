using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Listener_Entity : ListenerBase<Entity>
{
    public UnityEvent_Entity myResponse;

    public override void Call(Entity obj)
    {
        response = myResponse;
        base.Call(obj);
    }
}


[System.Serializable]
public class UnityEvent_Entity : UnityEvent<Entity>
{

}


/// <summary>
/// An EntityEvent is like a UnityEvent_Entity
/// The difference is that it can take multiple parameters
/// </summary>
[System.Serializable]
public class EntityEvent : UnityEvent2<Entity>
{

}