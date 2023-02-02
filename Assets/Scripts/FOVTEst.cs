using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOVTEst : MonoBehaviour
{
    [Range(0,3)]
    public int dir = 0;
    public float range;
    [Range(0,360)]
    public float angle;
    float rays = 20;

    private void OnDrawGizmos()
    {
        Vector2 origin = transform.position;
        float startAngle = GetStartAngle(dir, angle);

        Gizmos.color = Color.red;
        Vector2 d = Quaternion.AngleAxis(startAngle, -transform.forward) * transform.up;
        Gizmos.DrawRay(origin, d * range);

        Gizmos.color = Color.white;
        for (int i = 1; i <= rays; i++)
        {
            float newAngle = startAngle + (angle / rays) * i;
            Vector2 direction = Quaternion.AngleAxis(newAngle, -Vector3.forward) * Vector2.up;
            Gizmos.DrawRay(origin, direction * range);
        }
    }

    public float GetStartAngle(int dir, float angle)
    {
        float startAngle = (dir * 90f) - (angle/2);
        if (startAngle < 0)
        {
            startAngle += 360;
        }

        return startAngle;
    }
}
