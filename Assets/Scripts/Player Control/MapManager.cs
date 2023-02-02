using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class MapManager : MonoBehaviour
{
    private PlayerController controller;
    public GameEvent boat, player;
    public UnityEvent mapOpen, mapClose;


    private void Awake()
    {
        controller = GetComponent<PlayerController>();
    }
    public void OpenMap(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            if (controller.GetCurrent()=="Character")
            {
                player.Call();
            }
            else
            {
                boat.Call();
            }
            mapOpen.Invoke();
        }               
    }

    public void CloseMap(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            mapClose.Invoke();
        }        
    }
}
