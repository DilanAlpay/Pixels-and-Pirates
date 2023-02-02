using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleTester : MonoBehaviour
{
    public float angle;
    public float offset;
    public Transform target;

    private void OnDrawGizmos()
    {
        if (target)
        {
            Vector2 v = (target.position - transform.position).normalized;
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, v);
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, Formulas.AngleToVector(Formulas.VectorToAngle(v) + offset).normalized);
        }
        else
        {
            Gizmos.color = Color.green;
            Gizmos.DrawRay(transform.position, Formulas.AngleToVector(0));
            Gizmos.color = Color.red;
            Gizmos.DrawRay(transform.position, Formulas.AngleToVector(angle + offset).normalized);
        }
    }

    
}
