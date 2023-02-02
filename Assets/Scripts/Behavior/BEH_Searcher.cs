using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
/// <summary>
/// Constantly looks for an object on a specific layer
/// When the object is found, it performs an Event 
/// We define this Event in the Inspector
/// </summary>
public class BEH_Searcher : Behavior
{
    public float radius = 1;
    /// <summary>
    /// How much larger the radius increases when it is chasing after something
    /// if the target escapes the chaseMultiplier then the Searcher calls onLost
    /// </summary>
    public float chaseMult = 2;
    public LayerMask targets;

    public UnityEvent_Transform onFound, onLost;
    private bool chasing = false;
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        if (!allowed) return;
        Search();
    }

    public void Search()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, targets);
        if (!chasing && hit)
        {
            chasing = true;
            target = hit.transform;
            onFound.Invoke(hit.transform);
        }
        else if (chasing && (target==null || hit==null || hit.transform != target) )
        {
            chasing = false;
            target = null;
            onLost.Invoke(null);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}