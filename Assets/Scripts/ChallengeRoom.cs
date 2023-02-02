using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChallengeRoom : MonoBehaviour
{
    [Header("Treasure Options")]
    public List<ItemObj> options;
    public PoolType type;
    List<Treasure> treasures;

    [Header("Wave Management")]
    public int waves;
    public int current = 0;

    // Start is called before the first frame update
    void Start()
    {
        treasures = new List<Treasure>();

        //Fill the list of options with items
        for (int i = 0; i < options.Count; i++)
        {
            Treasure treasure;
            do
            {
                treasure = Archipelago.instance.guide.GetTreasure(type);
            } while (treasures.Contains(treasure));

            treasures.Add(treasure);
            options[i].Set(treasure);
        }
    }

    public void Choose(int choice)
    {
        for (int i = 0; i < options.Count; i++)
        {
            options[i].gameObject.SetActive(i == choice);
        }
    }

    public void SpawnWave()
    {

    }
   
}
