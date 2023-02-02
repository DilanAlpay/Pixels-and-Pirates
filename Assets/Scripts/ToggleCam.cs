using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleCam : MonoBehaviour
{
    private Camera cam;

    private void Start()
    {
        cam = GetComponent<Camera>();
    }
    public void Toggle()
    {
        cam.enabled = !cam.enabled;
    }

    public void TurnOff()
    {
        cam.enabled = false;
    }
}
