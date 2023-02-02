using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Formulas
{
    public static float VectorToAngle(Vector2 v)
    {
        float a = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        if (v.x < 0) a = 360 - (a * -1);
        return a;
    }

    public static Vector2 AngleToVector(float a)
    {
        return (Vector2)(Quaternion.Euler(0, 0, a) * Vector2.right);
    }
}
