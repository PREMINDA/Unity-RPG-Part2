using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [Header("Type of Item")]
    public bool isItem;
    public bool isWeapon;
    public bool isArmour;

    [Header("Item Detail")]
    public string itemName;
    public string description;
    public int value;
    public Sprite itemSprite;

    [Header("Affect Amount")]
    public int amountToChange;
    public bool affectHp,affectMp,affectStrength;

    [Header("Weapon & Armour")]
    public int weaponStrength;
    public int armourStrength;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
