using System;
using UnityEngine;
[Serializable]
public class Charactervariable
{
    public int health;
    public int maxhealth;
    public int mp;
    public int maxmp;
    public int strength;
    public int magic_power;
    public int speed; 
    public enum Character {Knight, Mage, Rogue, Rune_Fencer, Scholar, Archer};
    public Character role;
    public String character_name;
    public String character_description;
    public String assetsName;

}
