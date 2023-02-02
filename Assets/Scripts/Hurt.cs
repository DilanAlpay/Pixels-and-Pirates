using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurt : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.GetComponent<HP>())
        {
            collision.gameObject.GetComponent<HP>().Hurt(1);
        }
    }
}
