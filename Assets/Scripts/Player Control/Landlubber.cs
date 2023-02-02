using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

/// <summary>
/// A component on moving objects that prevent them 
/// from leaving the land and going over water or obstacles
/// </summary>
public class Landlubber : MonoBehaviour
{
    public LayerMask land;
    public Vector3 offset;  //How far from the center we are
    public float radius = .01f;
    public UnityEvent2 leftLand,backOnLand;
    private Vector3 lastPos;
    private bool landed = true;

    private void Start()
    {
        lastPos = transform.position;
    }
    // Update is called once per frame

    void Update()
    {
        Vector3 pos = transform.position + offset;
        if (Physics2D.OverlapCircle(pos, radius, land) == null)
        {
            if (leftLand.GetPersistentEventCount() == 0)
            {
                transform.position = lastPos;
            }
            else if (landed)
            {
                landed = false;
                leftLand.Invoke();
            }
        }
        else
        {
            lastPos = transform.position;
            if (!landed)
            {
                backOnLand.Invoke();
            }
            landed = true;
        }
    }
}
