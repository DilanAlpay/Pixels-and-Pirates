using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD : MonoBehaviour
{
    public Player player;

    [Header("Health")]
    public Text number;
    public Image bar;
    public Transform bonus;
    private HP health;

    [Header("Item")]
    public Image chargebar;
    public Image itemIcon;
    public Text timeDisplay;
    private float timeLeft;

    [Header("Weapon")]
    public Image weapon1;
    public Image weapon2;

    [Header("Stats")]
    public Text speed;
    public Text size;
    public Text dist;
    public Text power;
    public Text rate;
    public Text force; 

    private void Start()
    {
        health = player.GetComponent<HP_Player>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealth();
        UpdateItem();
        UpdateWeapon();
        UpdateStats();
    }

    void UpdateHealth()
    {
        number.text = (int)(health.GetHP()*10) + "/" + health.max*10;
        bar.fillAmount = (float)health.GetHP() / (float)health.max;
        for (int i = 0; i < bonus.childCount; i++)
        {
            bonus.GetChild(i).gameObject.SetActive(i < health.bonus);
        }
    }

    void UpdateItem()
    {
        ItemInstance item = player.GetItem();
        if (item == null) return;

        itemIcon.sprite = item.item.icon;
        if (!item.CheckStatus(Item.Status.READY))
        {
            float endTime = item.GetTime();
            timeLeft = (endTime - Time.time);
            float charge = timeLeft / item.item.duration;
            if (item.CheckStatus(Item.Status.CHARGING))
            {
                charge = 1 - timeLeft / item.item.recharge;
            }
            chargebar.fillAmount = charge;
            timeDisplay.text = (int)timeLeft + " sec";
        }
        else
        {
            timeDisplay.text = "READY";
        }
    }
   
    void UpdateWeapon()
    {
        weapon1.sprite = player.weapon1.icon;
        weapon2.sprite = player.weapon2.icon;
    }


    public void UpdateStats()
    {
        speed.text = player.stats.GetStat(Stat.MOVE).ToString();
        size.text = player.stats.GetStat(Stat.SCALE).ToString();
        dist.text = player.stats.GetStat(Stat.DISTANCE).ToString();
        power.text = player.stats.GetStat(Stat.POWER).ToString();
        rate.text = player.stats.GetStat(Stat.RATE).ToString();
        force.text = player.stats.GetStat(Stat.BULLETSPEED).ToString();
    }
}
