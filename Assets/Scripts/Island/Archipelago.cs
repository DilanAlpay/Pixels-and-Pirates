using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Archipelago : MonoBehaviour
{
    public static Archipelago instance;
    public ArchipelagoGuide guide;
    public List<Transform> spots;
    public List<Sprite> areaIcons;
    public LayerMask boat;
    /// <summary>
    /// List of the islands we have chosen to be in this Archipelago
    /// </summary>
    public List<IslandInfo> islands = new List<IslandInfo>();
    private Dictionary<Transform, IslandArea> areas;
    private int islandSize = 160;

    /// <summary>
    /// List of all of the areas we are currently near
    /// </summary>
    public List<Transform> occupied = new List<Transform>();
    #region OnAwake
    void Awake()
    {
        instance = this;
        ChooseIslands();
        FillAreas();
    }
    
    public void ChooseIslands()
    {
        //There are 25 islands in an archipelago
        //This list will have 24 island in it
        //The 25th island is the one the player starts on

        //ADDING IN THE ISLANDS TO THE LIST OF OPTIONS
        for (int i = 0; i < 8; i++)
        {
            islands.Add(guide.GetIsland(IslandType.ISLAND, islands));
        }
        islands.Add(guide.GetIsland(IslandType.SHOP, islands));
        islands.Add(guide.GetIsland(IslandType.CAVE, islands));
        
        for (int i = 0; i < 14; i++)
        {
            islands.Add(guide.GetIsland(IslandType.NONE, islands));
        }
    }

    public void FillAreas()
    {
        areas = new Dictionary<Transform, IslandArea>();

        // Set the starting location as empty
        IslandArea start = new IslandArea(guide.GetIsland(IslandType.NONE, islands), spots[22]);
        areas.Add(spots[22], start);
        spots[22].name = "START";

        for (int i = 0; i < 25; i++)
        {
            if (i!=22)
            {
                int r = Random.Range(0, islands.Count);
                IslandArea newArea = new IslandArea(islands[r], spots[i]);
                islands.RemoveAt(r);

                areas.Add(spots[i], newArea);
                newArea.SetIcon(areaIcons[(int)(newArea.GetIslandType())]);

                spots[i].name = newArea.island ? newArea.island.name : "_";
            }           
        }

        //Now we set the neighbors
        for (int i = 0; i < 25; i++)
        {
            //Set Neighbors
            IslandArea n = i - 5 >= 0        ? areas[spots[i - 5]] : null;
            IslandArea e = (i + 1) % 5 != 0  ? areas[spots[i + 1]] : null;
            IslandArea s = i + 5 <= 24       ? areas[spots[i + 5]] : null;
            IslandArea w = i % 5 != 0        ? areas[spots[i - 1]] : null;

            areas[spots[i]].SetNeighbors(n, e, s, w);
        }
    }
    #endregion

    private void Update()
    {
        CheckIslands();
    }

    public void CheckIslands()
    {
        foreach (Transform spot in spots)
        {
            IslandArea area = areas[spot];
            //Go through each location and see if the BOAT is there
            Vector2 size = new Vector2(islandSize, islandSize);
            Collider2D hit = Physics2D.OverlapBox(spot.position, size, 0, boat);
            if(hit && !occupied.Contains(spot))
            {
                LoadIsland(area);
            }
            //If the boat is not in a square that it was already in, then we leave
            else if (!hit&&occupied.Contains(spot))
            {
                occupied.Remove(spot);
                if (area.island != null)
                    SceneManager.UnloadSceneAsync(area.island.name);
            }
        }
    }

    public void LoadIsland(IslandArea area)
    {
        occupied.Add(area.area);
        area.IslandFound();
        //We have found a boat
        if (area.island != null)
            SceneManager.LoadScene(area.island.name, LoadSceneMode.Additive);
    }


    public void NewIsland(MonoBehaviour mono)
    {
        Island island = (Island)mono;

        //Match this island to one of our areas
        int x = 0;
        IslandArea islandArea = null;

        while (x < 25 && islandArea == null)
        {
            if (areas[spots[x]].island==island.info)
            {
                islandArea = areas[(spots[x])];
            }
            x++;
        }
        island.SetGuide(guide);
        island.SetParent(islandArea);


    }
}
