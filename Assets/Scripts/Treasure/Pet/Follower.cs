using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follower : SpawnableEffect
{
    public float speed = 1;
    public Entity leader;
    public Vector2 lastDir;
    public bool following = true;
    /// <summary>
    /// The shortest distance away from the leader when we start following
    /// </summary>
    public float minFollow;

    public override void Spawn(Entity e, float duration)
    {
        leader = e;
    }
    private void Update()
    {
        if(Vector2.Distance(transform.position, leader.transform.position) >= minFollow)
        {
            transform.position = Vector2.MoveTowards(transform.position, (Vector2)leader.transform.position + (Vector2.up * leader.offsetY), speed * Time.deltaTime);
        }
    }
}
