using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Weapon/Ranged")]
public class Weapon_Ranged : Weapon
{
    public List<float> angles;
    public Bullet bullet;
    public override void Attack(Vector3 spawnPoint, Vector2 dir, WeaponInstance instance)
    {

        float scale =   instance.scale;
        float dist =    instance.dist;
        float power =   instance.power;
        float bSpeed =  instance.bSpeed;
        
        List<Vector2> directions = new List<Vector2>();
        if (angles.Count == 0)
        {
            directions.Add(dir.normalized * bSpeed);
        }
        else
        {
            float a = Formulas.VectorToAngle(dir);
            foreach (float angle in angles)
            {
                directions.Add(Formulas.AngleToVector(a + angle).normalized * bSpeed);
            }
        }
        foreach (Vector2 direction in directions)
        {
            //Makes a bullet
            Bullet newBullet = Instantiate(bullet, spawnPoint, Quaternion.LookRotation(Vector3.back, direction));
            newBullet.transform.localScale *= scale;
            newBullet.Init(instance, direction, power);
            Debug.Log("I just spawned a bullet for " + dist);
            Destroy(newBullet.gameObject, dist);
        }
    }    
}
