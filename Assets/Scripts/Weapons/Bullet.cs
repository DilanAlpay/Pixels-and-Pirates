using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public LayerMask targets;
    public bool destructable = false;
    public bool makesContact = false;
    private WeaponInstance instance;
    private float power;

    public void Init(WeaponInstance i, Vector3 v, float p)
    {
        instance = i;
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.velocity = v;
        //If it is not moving, it's not moving
        body.isKinematic = (body.velocity.magnitude == 0);
        power = p;        
    }

    private void Update()
    {
        //Draw a circle around the character
        Collider2D[] hits = new Collider2D[10];
        ContactFilter2D filter = new ContactFilter2D();
        filter.SetLayerMask(targets);
        filter.useLayerMask = true;
        filter.useDepth = false;
        int numberOfHits = Physics2D.OverlapCollider(GetComponent<Collider2D>(), filter, hits);

        for (int i = 0; i < numberOfHits; i++)
        {
            Collider2D hit = hits[i];
            Hurt(hit.GetComponent<HP>());
        }

        if (numberOfHits > 0)
        {
            //Destroy(this);
            if (destructable)
            {
                print("WA");
                Destroy(gameObject);
            }
        }
    }

    private void Hurt(HP hp)
    {
        if (makesContact)
        {
            hp.Hurt(power, instance);
        }
        else
        {
            hp.Hurt(power);
        }
    }

    private void OnDestroy()
    {

    }
}
