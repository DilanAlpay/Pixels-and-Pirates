using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class EffectZone : MonoBehaviour
{
    public bool destroyAfter = false;
    public LayerMask targets;
    public bool oneHit = false;
    public EntityEvent onEnter;

    private new Collider2D collider;
    private List<Entity> hitEntities;

    private void Awake()
    {
        collider = GetComponent<Collider2D>();
        if (oneHit)
        {
            hitEntities = new List<Entity>();
        }
    }
    private void Update()
    {
        List<Collider2D> hits = new List<Collider2D>();
        ContactFilter2D filter = new ContactFilter2D();
        filter.SetLayerMask(targets);
        if (Physics2D.OverlapCollider(collider, filter, hits) > 0)
        {
            foreach (Collider2D hit in hits)
            {
                Entity entity = hit.GetComponent<Entity>();
                if (entity)
                {
                    onEnter.Invoke(entity);
                    if (destroyAfter)
                    {
                        Destroy(gameObject);
                    }
                }
            }
        }       
    }
}
