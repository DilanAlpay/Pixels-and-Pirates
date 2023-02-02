using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Stats are used by Treasures, Items, and Weapons to modify the EntityStats of their owners
/// </summary>
[System.Serializable]
public class Stats
{
    public float maxHealth;
    public float move = 1;
    public float scale;
    public float dist;
    public float power;
    public float rate;
    public float bSpeed;

    public Stats(int mH, float sp, float sz, float ds, float pw, float rt, float fr)
    {
        maxHealth = mH;
        move = sp;
        scale = sz;
        dist = ds;
        power = pw;
        rate = rt;
        bSpeed = fr;
    }

    public Stats(Stats s)
    {
        maxHealth = s.maxHealth;
        move = s.move;
        scale = s.scale;
        dist = s.dist;
        power = s.power;
        rate = s.rate;
        bSpeed = s.bSpeed;
    }

    public void AddStat(Stat stat, float f)
    {
        switch (stat)
        {
            case Stat.HEALTH:
                maxHealth += f;
                break;
            case Stat.MOVE:
                move += f;
                break;
            case Stat.SCALE:
                scale += f;
                break;
            case Stat.DISTANCE:
                dist += f;
                break;
            case Stat.POWER:
                power += f;
                break;
            case Stat.RATE:
                rate += f;
                break;
            case Stat.BULLETSPEED:
                bSpeed += f;
                break;
        }
    }

    public float GetStat(Stat stat)
    {
        switch (stat)
        {
            case Stat.HEALTH:
               return  maxHealth;
            case Stat.MOVE:
               return move;
            case Stat.SCALE:
               return scale;
            case Stat.DISTANCE:
              return  dist;
            case Stat.POWER:
               return power;
            case Stat.RATE:
               return rate;
            case Stat.BULLETSPEED:
              return  bSpeed;
        }

        return 0;
    }
    public void SetStat(Stat stat, float f)
    {
        switch (stat)
        {
            case Stat.HEALTH:
                maxHealth = (int)f;
                break;
            case Stat.MOVE:
                move = f;
                break;
            case Stat.SCALE:
                scale = f;
                break;
            case Stat.DISTANCE:
                dist = f;
                break;
            case Stat.POWER:
                power = f;
                break;
            case Stat.RATE:
                rate = f;
                break;
            case Stat.BULLETSPEED:
                bSpeed = f;
                break;
        }
    }
    public void MultiplyStat(Stat stat, float multiplier)
    {
        switch (stat)
        {
            case Stat.HEALTH:
                maxHealth = (int)(maxHealth * multiplier);
                break;
            case Stat.MOVE:
                move *= multiplier;
                break;
            case Stat.SCALE:
                scale *= multiplier;
                break;
            case Stat.DISTANCE:
                dist *= multiplier;
                break;
            case Stat.POWER:
                power *= multiplier;
                break;
            case Stat.RATE:
                rate *= multiplier;
                break;
            case Stat.BULLETSPEED:
                bSpeed *= multiplier;
                break;
        }
    }

    public void Add(Stats s)
    {
        maxHealth   += s.maxHealth;
        move       += s.move;
        scale        += s.scale;
        dist        += s.dist;
        power       += s.power;
        rate        += s.rate;
        bSpeed       += s.bSpeed;
    }
    public void Remove(Stats s)
    {
        maxHealth   -= s.maxHealth;
        move       -= s.move;
        scale        -= s.scale;
        dist        -= s.dist;
        power       -= s.power;
        rate        -= s.rate;
        bSpeed       -= s.bSpeed;
    }
    public void Copy()
    {

    }
}

public enum Stat
{
    NULL,
    HEALTH,
    MOVE,
    SCALE,
    DISTANCE,
    POWER,
    RATE,
    BULLETSPEED
}
