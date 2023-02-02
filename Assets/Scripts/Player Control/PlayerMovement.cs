using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

/// <summary>
/// 2D movement system. 
/// Requires external input from the new Input system
/// </summary>
[RequireComponent(typeof(Player))]
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    Player player;
    private Rigidbody2D rb;
    private Animator anim;
    private bool facingRight = true;
    private Vector2 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    public void SetAnimator(Animator a)
    {
        anim = a;
    }

    // Update is called once per frame
    void Update()
    {
        anim?.SetFloat("speed", rb.velocity.magnitude);
    }

    public void OnMovement(InputValue value)
    {
       Move(value.Get<Vector2>(), player.GetStat(Stat.MOVE));
    }

    public void Move(Vector2 input, float speed)
    {
        direction = input;
        rb.velocity = direction * speed;

        if (direction.x < 0)
        {
            //anim.transform.parent.eulerAngles = Vector3.up * 180;
            facingRight = false;
        }
        else if (direction.x > 0)
        {
            //anim.transform.parent.eulerAngles = Vector3.zero;
            facingRight = true;
        }
    }

    public bool IsMoving()
    {
        return direction != Vector2.zero;
    }

    public Vector2 GetDirection()
    {
        return direction;
    }
}
