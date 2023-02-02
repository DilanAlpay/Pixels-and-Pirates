using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
public class Listener_Confine : ListenerBase<Collider>
{
    public CinemachineVirtualCamera cvc;
    private CinemachineConfiner confiner;

    private void Start()
    {
        confiner = cvc.GetComponent<CinemachineConfiner>();
    }
    public override void Call(Collider obj)
    {
        confiner.m_BoundingVolume = obj;
    }
}
