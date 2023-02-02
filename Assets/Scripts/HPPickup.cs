using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPPickup : MonoBehaviour
{
    public int hp = 1;
    public bool bonus = false;
    public bool permanent = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            HP player = collision.GetComponent<HP>();
            if (bonus)
            {
                player.Bonus(hp);
            }
            else if (permanent)
            {
                player.Increase(hp);
            }
            else
            {
                player.Heal(hp);
            }

            Destroy(gameObject);
        }
    }
}
