using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pace : MonoBehaviour
{
    //The marker is a dummy object we place in the game and delete
    public Transform marker;
    public float speed=1;
    private Vector3 start, end;
    private Vector3 goal;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        end = marker.position;
        Destroy(marker.gameObject);
        goal = end;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, goal, speed * Time.deltaTime);
        float dis = Vector3.Distance(transform.position,goal);

        //Check if we have reached our goal
        if (dis <.01f)
        {
            transform.position = goal;
            if (goal == start)
            {
                goal = end;
            }
            else
            {
                goal = start;
            }
        }        
    }

    private void OnDrawGizmos()
    {
        if(marker != null)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(transform.position, marker.position);
        }
    }
}
