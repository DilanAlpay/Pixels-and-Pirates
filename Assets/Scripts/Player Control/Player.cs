using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

[RequireComponent(typeof(HP))]
public class Player : Entity, Controllable
{
    public PlayerController controller;
    public Character choice;
    public Transform geo;

    /// <summary>
    /// The base weapons that your instances 
    /// are copying from when you start the game
    /// </summary>
    public Weapon weapon1, weapon2;
    public Item startingItem;

    /// <summary>
    /// The specific weapon you are holding right now.
    /// It will either be your melee or your ranged
    /// </summary>
    private WeaponInstance weapon;
    private Character character;
    private ItemInstance item;
    private WeaponInstance melee, ranged;
    private Animator anim;
    private SpriteRenderer hand;
    private PlayerMovement movement;
    private bool reloading = false;
    private List<Treasure> treasures;


    public override void Awake()
    {        
        //Set the character
        character = Instantiate(choice, geo);
            anim = character.anim;
            hand = character.hand;

        stats = new Stats(choice.stats);

        //Set the movement
        movement = GetComponent<PlayerMovement>();
        movement.SetAnimator(anim);

        //Set the Item
        if (startingItem)
        {
            item =new ItemInstance(startingItem, this);
        }

        //Set the Weapon
        GetWeapon(weapon2, new List<WeaponTag>());
        GetWeapon(weapon1, new List<WeaponTag>());

        treasures = new List<Treasure>();
        base.Awake();
    }

    void Update()
    {
        UpdateItem();       
    }
    

    #region Weapons
    public void ReadAttackInput(InputAction.CallbackContext context)
    {       
        Attack(context.ReadValue<Vector2>());
    }

    public void Attack(Vector2 direction)
    {
        if (weapon != null && !reloading && direction != Vector2.zero)
        {
            weapon.Fire(transform.position + offsetY * Vector3.up, direction);
            anim.SetTrigger(weapon.Type().ToString());
            reloading = true;
            Invoke("Reload", stats.GetStat(Stat.RATE));
        }
    }

    public void GetWeapon(Weapon w, List<WeaponTag> tags)
    {
        switch (w.type)
        {
            case WeaponType.melee:
                melee = new WeaponInstance(this, w, tags);
                SwitchTo(melee);
                break;

            case WeaponType.ranged:
                ranged = new WeaponInstance(this, w, tags);
                SwitchTo(ranged);
                break;
        }
    }

    public void Reload()
    {
        reloading = false;
    }

    /// <summary>
    /// Switches your current weapon with your secondary weapon
    /// </summary>
    public void Switch()
    {
        switch (weapon.Type())
        {
            case WeaponType.melee:
                SwitchTo(ranged);
                break;

            case WeaponType.ranged:
                SwitchTo(melee);
                break;
        }
    }

    public void SwitchTo(WeaponInstance w)
    {
        if (weapon != null)
        {
            stats.Remove(weapon.stats);
        }
        weapon = w;
        stats.Add(weapon.stats);
        hand.sprite = weapon.Sprite();
    }
    #endregion

    #region Treasures
    public void GiveTreasure(ScriptableObject sO)
    {
        if (sO is Item)
            return;
        AddTreasure((Treasure)sO);        
    }

    public void AddTreasure(Treasure t)
    {
        treasures.Add(t);
        t.Collect(this);
        foreach (Ability ability in t.abilities)
        {
            abilities.Add(ability);
            ability.Trigger(Trigger.INSTANT, this);
        }
    }
    
    /// <summary>
    /// Items must be set differently than Treasures 
    /// This is so they can be swapped on an ItemObj
    /// </summary>
    /// <param name="i"></param>
    public void SetItem(Item i)
    {
        item = new ItemInstance(i, this);
    }

    public void SetItem(ItemInstance i)
    {
        item = i;
    }

    public List<Treasure> GetTreasures()
    {
        return treasures;
    }

    public void ActivateItem()
    {
        if (item != null)
        {
            item.Activate();
        }
    }

    public void UpdateItem()
    {
        if (item != null)
        {
            item.Update();
        }
    } 

    public ItemInstance GetItem()
    {
        return item;
    }
    #endregion

    #region Triggers
    public void Trigger_Hurt(WeaponInstance wi)
    {
        foreach (Ability ability in abilities)
        {
            ability.Trigger(Trigger.HURT, this, wi.owner);
        }
    }
    #endregion 

    public void Pause()
    {
        //pause.Invoke();
    }

    public void TryDig()
    {
        //movement.enabled = false;
        anim.SetTrigger("dig");
    }

    public Transform GetGEO()
    {
        return anim.transform;
    }

    public override bool IsMoving()
    {
        return movement.IsMoving();
    }

    public override Vector2 GetDirection()
    {
        return movement.GetDirection();
    }
}
