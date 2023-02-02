using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public ObjList waveOptions;

    /// <summary>
    /// List of the waves we have already chosen
    /// </summary>
    private List<int> removed;

    public int total, count;
    public float delay = 3;
    public GameObject wave;

    public GameEvent spawned, cleared,finished;


    public void Begin()
    {
        Invoke("Spawn", delay);
        removed = new List<int>();
    }

    public void Spawn()
    {       
        int choice;
        do
        {
            choice = Random.Range(0, waveOptions.Count);
        } while (removed.Contains(choice));

        wave = Instantiate(waveOptions.Get(choice), transform);
        spawned.Call();
        removed.Add(choice);
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (wave && wave.transform.childCount == 0)
        {
            cleared.Call();
            Destroy(wave);
            if (count==total)
            {
                finished.Call();
            }
            else
            {
                Invoke("Spawn", delay);
            }
        }
    }
}
