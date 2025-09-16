using UnityEngine;
using System;
[Serializable]

public class Items
{
    public string name;
    public enum itemType{Armor, Weapon, Misc};
    public itemType t;
    public int damage;
    public int defence;
    public int durability;
    public string description;
}
