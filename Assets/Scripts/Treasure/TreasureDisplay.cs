using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TreasureDisplay : MonoBehaviour
{
    public Player player;
    public Transform imageParent;

    private void OnEnable()
    {
        List<Treasure> treasures = player.GetTreasures();
        if (treasures == null) return;

        for (int i = 0; i < treasures.Count; i++)
        {
            Image image = imageParent.GetChild(i).GetComponent<Image>();
            image.gameObject.SetActive(true);
            image.sprite = treasures[i].icon;
        }
    }

    
}
