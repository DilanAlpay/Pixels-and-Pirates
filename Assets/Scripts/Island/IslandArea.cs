using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Holds all of the information for an island that is in our archipelago
/// </summary>
public class IslandArea
{
    /// <summary>
    /// Picture of the island that goes on the map
    /// </summary>
    public IslandInfo island;

    /// <summary>
    /// Transform parent of this Island
    /// </summary>
    public Transform area;

    public SpriteRenderer display;


    /// <summary>
    /// True after the boat enters the area for the first time
    /// </summary>
    public bool entered;

    /// <summary>
    /// True when the area is made visible on the map, likely by entering an adjacent area
    /// </summary>
    public bool visible;

    /// <summary>
    /// True the first time that the player steps on this island
    /// </summary>
    public bool landed;

    /// <summary>
    /// True if the Island's scene is currently loaded
    /// </summary>
    public bool loaded;

    /// <summary>
    /// Which Island from the list this was
    /// </summary>
    public int number;


    /// <summary>
    /// North, East, South, West
    /// </summary>
    private IslandArea[] neighbors;
    

    public IslandArea(IslandInfo i, Transform a)
    {
        island = i;
        area = a;
        display = area.GetChild(0).GetComponent<SpriteRenderer>();
    }


    /// <summary>
    /// Called when the player enters the IslandArea
    /// </summary>
    public void IslandFound()
    {
        ShowOnMap();
        ShowNeighbors();
    }

    /// <summary>
    /// Called by the Island loaded when entering this IslandArea
    /// </summary>
    /// <returns></returns>
    public bool Enter()
    {
        loaded = true;
        if (!entered)
        {
            entered = true;           
            return true;
        }
        return false;
    }

    public void ShowOnMap()
    {
        visible = true;
        display.enabled = true;
    }

    public void SetNeighbors(IslandArea n, IslandArea e, IslandArea s, IslandArea w)
    {
        neighbors = new IslandArea[4];
        neighbors[0] = n;
        neighbors[1] = e;
        neighbors[2] = s;
        neighbors[3] = w;
    }

    public void ShowNeighbors()
    {
        foreach (IslandArea n in neighbors)
        {
            n?.ShowOnMap();
        }
    }

    public IslandType GetIslandType()
    {
        return island == null ? IslandType.NONE : island.type;
    }

    public void SetIcon(Sprite s)
    {
        display.sprite = s;
        display.enabled = false;
    }

}