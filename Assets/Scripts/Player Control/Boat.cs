using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;
public class Boat : MonoBehaviour
{
    public PlayerController controller;
    public float speed;
    public Player player;    
    public Animator anim;
    public bool boarded = true;
    public float boardingRadius = 3;
    public LayerMask dockLayer, playerLayer;
    public UnityEvent onDock, onBoard;
    private PlayerMovement movement;
    private List<Vector3> spots;

    // Start is called before the first frame update
    void Start()
    {
        //player.SetActive(false);
        movement = GetComponent<PlayerMovement>();
        movement.SetAnimator(anim);

        spots = new List<Vector3>();
        spots.Add(new Vector2(0, 4));
        spots.Add(new Vector2(-6, -.5f));
        spots.Add(new Vector2(6, -.5f));
        spots.Add(new Vector2(0, -7));
    }

    public void Move(InputAction.CallbackContext ctx)
    {
        movement.Move(ctx.ReadValue<Vector2>(), speed);
    }

    public void AttemptDock(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            print("Attempting to dock...");
            float radius = .1f;
            Vector3 landingSpot = Vector3.zero;
            Collider2D land = null;

            foreach (Vector3 spot in spots)
            {
                //how big the box is, width by height
                //Hits is a list of objects that were in our box
                Collider2D[] hits = Physics2D.OverlapCircleAll(spot + transform.position, radius, dockLayer);
                if (hits.Length == 1 && hits[0].gameObject.layer == LayerMask.NameToLayer("Land"))
                {
                    land = hits[0];
                    landingSpot = spot + transform.position;
                    break;
                }
            }

            //We are docking!
            if (landingSpot != Vector3.zero)
            {
                Dock(land, landingSpot);
            }
        }       
    }

    public void Dock(Collider2D land, Vector3 landingSpot)
    {
        print("Now leaivng the ship");
        land.transform.parent.GetComponentInChildren<Island>().Enter(player);
        // putting the player on land
        player.transform.position = landingSpot;

        onDock.Invoke();

        boarded = false;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())
        {
            Board();
        }
    }

    public void Board()
    {
        onBoard.Invoke();
        boarded = true;    
    }
}
