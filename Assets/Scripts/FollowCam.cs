using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCam : MonoBehaviour
{
    public Transform target;
    
    public void SetTarget(Transform t)
    {
        target = t;
    }
}
