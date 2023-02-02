using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class TileConverter : MonoBehaviour
{
    public List<TileRule> rules;
    

    // Start is called before the first frame update
    void Awake()
    {
        //Make the list of rules easier to work with
        Dictionary<Tile, Transform> dic = new Dictionary<Tile, Transform>();
        foreach (TileRule rule in rules)
        {
            dic.Add(rule.tile, rule.obj);
        }

        //Get the tiles from the map
        Tilemap map = GetComponent<Tilemap>();
        BoundsInt bounds = map.cellBounds;
        TileBase[] tiles = map.GetTilesBlock(bounds);
        Vector3 offset =map.origin+map.tileAnchor;

        //Turn each tile into an object
        for (int x = 0; x < bounds.size.x; x++)
        {
            for (int y = 0; y < bounds.size.y; y++)
            {
                Tile tile = (Tile)tiles[x + y * bounds.size.x];
                if (tile!=null &&dic.ContainsKey(tile))
                {
                    Vector2 pos = new Vector3(x, y,0) + offset;
                    Instantiate(dic[tile], pos, dic[tile].rotation).parent = transform;
                    
                }
            }
        }

        //Turn off the map
        map.GetComponent<TilemapRenderer>().enabled = false;
    }

   
}
