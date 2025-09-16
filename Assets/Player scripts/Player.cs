using System.IO;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    public Charactervariable player;
    void Start()
    {
        player.health = 100;
        player.maxhealth = 100;
        player.mp = 10;
        player.maxmp = 10;
        player.strength = 25;
        player.magic_power = 15;
        player.speed = 20;
        player.character_description = "En knight som hedder Jakob";
        player.role = Charactervariable.Character.Knight;
        player.character_name = "Jakob";

        string json = JsonUtility.ToJson(player);
        Debug.Log(json);
        string path = "Assets/Knight.json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();

    }


}
