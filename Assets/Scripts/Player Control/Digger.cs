using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Digger : MonoBehaviour
{
    public float radius;
    public LayerMask targets;
    //private PlayerMovement movement;

    private void Start()
    {
        //movement = GetComponent<PlayerMovement>();
    }
    public void Dig()
    {
        Collider2D[] hits = Physics2D.OverlapCircleAll(transform.position, radius, targets);
        foreach (Collider2D item in hits)
        {
            Diggable diggable = item.GetComponent<Diggable>();
            if (diggable!=null)
            {
                diggable.Dig();
            }
        }
        //movement.enabled = true;
    }

}
