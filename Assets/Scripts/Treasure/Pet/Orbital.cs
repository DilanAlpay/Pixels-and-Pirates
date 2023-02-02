using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbital : SpawnableEffect
{
    public float radius;
    public float speed;
    public Transform geo;
    private float angle;
    // Update is called once per frame
    void FixedUpdate()
    {
        angle += speed * Time.deltaTime;
        Vector3 offset = new Vector2(Mathf.Sin(angle), Mathf.Cos(angle)) * radius;

        geo.position = transform.position + offset;
    }
}
