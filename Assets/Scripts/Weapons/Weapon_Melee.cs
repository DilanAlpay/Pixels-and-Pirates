using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Weapon/Melee")]
public class Weapon_Melee : Weapon
{
    private int rays = 20;
    public LayerMask targets;

    /// <summary>
    /// Hurts the enemy
    /// </summary>
    /// <param name="spawnPoint"></param>
    /// <param name="dir"></param>
    /// <param name="instance"></param>
    public override void Attack(Vector3 spawnPoint, Vector2 dir, WeaponInstance instance)
    {
        float a = Vector2.Angle(Vector2.up, dir);      
        a = dir.x < 0 ? 360 - a : a;

        float size = instance.scale;
        float dist = instance.dist;
        float power = instance.power;

        List <Collider2D> hits = GetTargets(spawnPoint, a, size, dist);
        foreach (Collider2D hit in hits)
        {
            hit.GetComponent<HP>()?.Hurt(power, instance);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="origin"></param>
    /// <param name="dir"></param>
    /// <param name="angle"></param>
    /// <param name="range"></param>
    /// <returns></returns>
    public List<Collider2D> GetTargets(Vector2 origin, float dir, float angle, float range)
    {
        float startAngle = GetRange(dir, angle);
        List<Collider2D> hits = new List<Collider2D>();
        for (int i = 0; i <= rays; i++)
        {
            float a = startAngle + (angle / rays) * i;
            Vector2 direction = Quaternion.AngleAxis(a, -Vector3.forward) * Vector2.up;
            RaycastHit2D hit = Physics2D.Raycast(origin, direction, range, targets);
            if (hit.collider && !hits.Contains(hit.collider) && hit.collider.GetComponent<HP>())
            {
                hits.Add(hit.collider);
            }
        }

        return hits;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="dir"> The angle from the player to get the range of </param>
    /// <param name="a"> How wide of an area you want</param>
    /// <returns></returns>
    public float GetRange(float dir, float a)
    {       
        Vector2 r = Vector2.one * dir;
        r.x -= a / 2;

        if (r.x < 0)
        {
            r.x = 360 + r.x;
        }

        return r.x;
    }
}
