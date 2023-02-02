using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventCaller : MonoBehaviour
{
    public GameEvent myEvent;    

    public void Call()
    {
        myEvent.Call();
    }

    public void CallEvent(GameEvent thisEvent)
    {
        thisEvent.Call();
    }
}
