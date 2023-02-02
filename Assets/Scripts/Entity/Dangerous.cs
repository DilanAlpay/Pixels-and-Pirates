using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Used for any damaging object not associated with an enemy
/// </summary>
public class Dangerous : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<HP>()?.Hurt(damage);
    }

    private void OnParticleCollision(GameObject other)
    {
        other.GetComponent<HP>()?.Hurt(damage);
    }
}
