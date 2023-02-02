using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using Cinemachine;
public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public CinemachineVirtualCamera cvc;
    private CinemachineConfiner confiner;
    public Collider levelCol;
    public UnityEvent onPause, onUnpause;
    private PlayerInput input;
    private string current, last, next;

    private void Start()
    {
        input = GetComponent<PlayerInput>();
        current = input.currentActionMap.name;
        last = current;
        Cursor.lockState = CursorLockMode.None;
        confiner = cvc.GetComponent<CinemachineConfiner>();
    }

    public string GetCurrent()
    {
        return current;
    }

    public void Switch(string n)
    {
        next = n;
        last = current;
        current = next;
        input.SwitchCurrentActionMap(current);
    }

    public void SwitchBack()
    {
        current = last;
        next = last;
        input.SwitchCurrentActionMap(current);
    }
    

    public void PressPause(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            if (Time.timeScale > 0)
            {
                Time.timeScale = 0;
                onPause.Invoke();
            }
            else
            {
                Time.timeScale = 1;
                onUnpause.Invoke();
            }
        }
    }

    public void SetConfiner(Collider c)
    {
        confiner.m_BoundingVolume = c != null ? c : levelCol;
    }

    public void ResetConfiner()
    {
        confiner.m_BoundingVolume = levelCol;
    }

}
