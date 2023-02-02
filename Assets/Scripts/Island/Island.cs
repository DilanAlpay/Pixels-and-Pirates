using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
/// <summary>
/// Used by an island to set its treasures
/// </summary>
public class Island : MonoBehaviour
{
    public IslandInfo info;
    public GameObject map;  //spawnable camera
    public GameEvent spawnEvent,visitEvent;
   
    protected ArchipelagoGuide archipelago;
    protected IslandArea area;
    //Used for the camera
    public Collider confiner;


    /// <summary>
    /// List of locations we have already put Digspots on
    /// </summary>
    protected List<Vector2> placed;

    private void Awake()
    {               
        spawnEvent.Call((MonoBehaviour)this);        
    }

    
  
    public virtual void Enter(Player player)
    {
        ///Turns this spot on your map green      
        player.controller.SetConfiner(confiner);
    }

    public void SetGuide(ArchipelagoGuide guide)
    {
        archipelago = guide;
    }

    public void SetParent(IslandArea a)
    {
        area = a;
        transform.parent.position = a.area.position;
        if (area.Enter())
        {
            //If this is our first time on the island we need to set it up
            FirstVisit();
        }
    }


    public virtual void FirstVisit()
    {
        visitEvent?.Call();
    }
}
