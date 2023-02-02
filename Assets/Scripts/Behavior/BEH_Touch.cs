using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BEH_Touch : Behavior
{
    /// <summary>
    /// Multiplier for how far out from the collider this radius will extend
    /// Ex: An enemy with a Circle collider will check in a circle that's 10% bigger for a target
    /// (O)
    /// </summary>
    public float range = 0.1f;
    public BoxCollider2D col;
    public LayerMask targets;
    private void Start()
    {
        if (!col)
        {
            col = GetComponent<BoxCollider2D>();
        }
    }
    private void Update()
    {
        Vector2 pos = (Vector2)col.transform.position + col.offset;
        Vector2 size = col.size * (1 + range);
        Collider2D[] hits = Physics2D.OverlapBoxAll(pos, size, 0, targets);
        foreach (Collider2D hit in hits)
        {
            hit.GetComponent<HP>()?.Hurt(entity.GetStat(Stat.POWER));
        }
    }
}
