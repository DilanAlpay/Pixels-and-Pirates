using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    public List<Weapon> weapons;

    private Weapon weapon;
    private List<WeaponTag> tags;
    public List<WeaponTagSet> stats;
    public SpriteRenderer plus, minus;

    private void Start()
    {
        weapon = weapons[Random.Range(0, weapons.Count)];
        GetComponent<SpriteRenderer>().sprite = weapon.icon;

        WeaponTagSet up = stats[Random.Range(0, stats.Count)];
        stats.Remove(up);
        plus.sprite = up.icon;

        WeaponTagSet down = stats[Random.Range(0, stats.Count)];
        stats.Remove(down);
        minus.sprite = down.icon;

        tags = new List<WeaponTag>();
        tags.Add(up.positive);
        tags.Add(down.negative);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Give(collision.GetComponent<Player>());
    }
    public void Give(Player character)
    {
        character.GetWeapon(weapon, tags);
        Destroy(gameObject);
    }
}
