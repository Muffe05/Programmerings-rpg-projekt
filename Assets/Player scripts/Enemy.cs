using UnityEngine;
[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/EnemyObject", order = 1)]

public class Enemy :ScriptableObject
{
    
    public string mName;
    public Sprite s;
    public int maxhealth;
    public int health;
    public int strength;
    public string description; 
}
