using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Island_Treasures : Island
{
    public DigSpot digspot;
    public int spotMax = 5; //How many spots we want to put on the map

    //Information about the LAND map
    protected Tilemap land;
    protected List<Tilemap> blocked;
    protected BoundsInt bounds; //how large the map is in each direction
    protected TileBase[] tiles; //List of every tile in the map
    protected Vector2 offset;//used for position
    private List<Diggable> digspots;

    public override void FirstVisit()
    {
        base.FirstVisit();

        land = transform.parent.Find("Land").GetComponent<Tilemap>();

        blocked = new List<Tilemap> {
            transform.parent.Find("Obstacles").GetComponent<Tilemap>()
        };

        //Information about the LAND map
        bounds = land.cellBounds; //how large the map is in each direction
        tiles = land.GetTilesBlock(bounds); //List of every tile in the map
        offset = land.origin + land.tileAnchor;//used for position

        PlaceSpots();
        PlaceEnemies();
    }

    public void PlaceSpots()
    {
        //List of all of our digspots
        placed = new List<Vector2>();
        DigSpot newSpot;

        //Spawns all of the REGULAR CHESTS
        for (int i = 0; i < spotMax; i++)
        {
            newSpot = AddDigSpot();
            newSpot.SetChest(archipelago.chestValuable);
        }

        //SPAWNS THE TREASURE CHEST
        newSpot = AddDigSpot();
        newSpot.SetChest(archipelago.chestTreasure);
        newSpot.SetTreasure(archipelago.GetTreasure(PoolType.CHEST));
    }

    public DigSpot AddDigSpot()
    {
        Vector2Int coordinates = GetValidPos();

        Vector2 pos = coordinates + offset + (Vector2)transform.position;
        placed.Add(pos);

        //Get all of the info for what will be in this spot
        DigSpot newSpot = Instantiate(digspot, pos, Quaternion.identity);       
        newSpot.SetInfo(new DigInfo(coordinates, false, false));
        newSpot.transform.parent = area.area;
        return newSpot;
    }

    public Vector2Int GetValidPos()
    {
        Vector2Int coordinates = new Vector2Int();
        TileBase tile;
        Vector3 pos;
        Vector3Int spot;
        bool spotBlocked;

        do
        {
            //Choose a NEW random X (left to right)
            coordinates.x = Random.Range(0, bounds.size.x);
            //Choose a NEW random Y (up and down)
            coordinates.y = Random.Range(0, bounds.size.y);

            tile = tiles[coordinates.x + coordinates.y * bounds.size.x];

            pos = coordinates + offset + (Vector2)transform.position;

            //Check to see if it is on the blocked layer
            spot = blocked[0].WorldToCell(pos);
            spotBlocked = blocked[0].GetTile(spot) != null;
        } while (tile == null || spotBlocked || placed.Contains(pos));

        return coordinates;
    }

    public void PlaceEnemies()
    {
        Transform enemyParent = transform.Find("Enemies");

        foreach (Transform spot in enemyParent)
        {
            GameObject enm = Instantiate(archipelago.GetEnemy(), spot.position, Quaternion.identity); ;
            enm.transform.parent = area.area;
        }
    }

}
