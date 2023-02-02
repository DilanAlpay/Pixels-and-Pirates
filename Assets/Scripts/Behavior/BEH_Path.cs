
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Moves in a direction until it hits a wall and will go in the opposite initial 0direction
/// </summary>
public class BEH_Path : Behavior
{

    public float speed;
    public List<Vector2> dirs = new List<Vector2>();
    List<Vector2> points;
    /// <summary>
    /// When true, this object is moving in its original direction
    /// When false, it is going in the opposite direction
    /// </summary>
    public bool fwd = true;
    public float range = 1;
    public Rigidbody2D body;

    private int nextPoint = 0;

    // Start is called before the first frame update
    void Start()
    {
        FillPoints();
        if (!body)
        {
            body = gameObject.GetComponentInParent<Rigidbody2D>();
        }
    }

    public void FillPoints()
    {
        points = new List<Vector2>();
        foreach (Vector2 dir in dirs)
        {
            points.Add((Vector2)transform.position + dir);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 dir = (points[nextPoint]-(Vector2)transform.position).normalized;
        body.velocity = dir * speed;
        if (Vector2.Distance(transform.position,points[nextPoint]) <= range)
        {
            nextPoint = (nextPoint + 1) % points.Count;
        }
    }

    private void OnDrawGizmosSelected()
    {
        for (int i = 0; i < dirs.Count; i++)
        {
            Vector2 start = (Vector2)transform.position + dirs[i];
            Vector2 end = (Vector2)transform.position + dirs[(i+1)%dirs.Count];
            Gizmos.DrawSphere(start, 0.5f);
            Gizmos.DrawLine(start, end);
        }
    }
}
