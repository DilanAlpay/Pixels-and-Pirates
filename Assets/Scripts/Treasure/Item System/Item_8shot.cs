using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_8shot : Item
{
    public Rigidbody2D bullet;
    public float speed, range;

    /*
    public override void Effect_Activate(Player player)
    {       
        Vector3 pos = player.transform.position;

        Vector2 N   = new Vector2(0, 1);
        Vector2 NE  = new Vector2(1, 1);
        Vector2 E   = new Vector2(1, 0);
        Vector2 SE  = new Vector2(1, -1);
        Vector2 S   = new Vector2(0, -1);
        Vector2 SW  = new Vector2(-1, -1);
        Vector2 W   = new Vector2(-1, 0);
        Vector2 NW  = new Vector2(-1, 1);

        Rigidbody2D b1 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,N));
        Rigidbody2D b2 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,NE));
        Rigidbody2D b3 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,E));
        Rigidbody2D b4 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,SE));
        Rigidbody2D b5 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,S));
        Rigidbody2D b6 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,SW));
        Rigidbody2D b7 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,W));
        Rigidbody2D b8 = Instantiate(bullet, pos + player.weaponoffset, Quaternion.LookRotation(Vector3.back,NW));

        b1.velocity = speed * N;
        b2.velocity = speed * NE;
        b3.velocity = speed * E ;
        b4.velocity = speed * SE;
        b5.velocity = speed * S ;
        b6.velocity = speed * SW ;
        b7.velocity = speed * W;
        b8.velocity = speed * NW ;

        Destroy(b1.gameObject, range);
        Destroy(b2.gameObject, range);
        Destroy(b3.gameObject, range);
        Destroy(b4.gameObject, range);
        Destroy(b5.gameObject, range);
        Destroy(b6.gameObject, range);
        Destroy(b7.gameObject, range);
        Destroy(b8.gameObject, range);
    }
    */
}
