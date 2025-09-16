using UnityEngine;
using UnityEngine.UI;
using System.IO;
using TMPro;

public class UIController : MonoBehaviour
{
    public static Charactervariable player;
    public TextMeshProUGUI health;
    public TextMeshProUGUI maxhealth;
    public TextMeshProUGUI mp;
    public TextMeshProUGUI maxmp;
    public TextMeshProUGUI strength;
    public TextMeshProUGUI magic_power;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI character_description;
    public TextMeshProUGUI role;
    public TextMeshProUGUI character_name;
    public files f;
    public int i = 0;
    public Image img;

    // Start is called before the first frame update
    void Start()
    {
        string path = "Assets/index.json";
        StreamReader t = new StreamReader(path);
        string temp = t.ReadToEnd();
        t.Close();
        f = JsonUtility.FromJson<files>(temp);
        Debug.Log(f.filnavn[0]);

        string path2 = "Assets/" + f.filnavn[i] + ".json";
        StreamReader tt = new StreamReader(path2);
        string temp2 = tt.ReadToEnd();
        tt.Close();
        player = JsonUtility.FromJson<Charactervariable>(temp2);
        Debug.Log(player.assetsName);
    }

// Update is called once per frame
void Update()
{
    health.text = "HP : " + player.health;
    mp.text = "MP : " + player.mp;
    strength.text = "Sta : " + player.strength;
    magic_power.text = "Mag : " + player.magic_power;
    speed.text = "Spd : " + player.speed;
    character_description.text = "Description : " + player.character_description;
    role.text = "Role : " + player.role;
    character_name.text = "Name : " + player.character_name;
    img.sprite = (Sprite)Resources.Load(player.assetsName, typeof(Sprite));
}

public void NextChar() {
    if (i < f.filnavn.Length - 1)
        i++;
    else
        i = 0;
    string path2 = "Assets/" + f.filnavn[i] + ".json";
    StreamReader tt = new StreamReader(path2);
    string temp2 = tt.ReadToEnd();
    tt.Close();
    player = JsonUtility.FromJson<Charactervariable>(temp2);
}

public void PrevChar() {
    if (i > 0)
        i--;
    else
        i = f.filnavn.Length - 1;
    string path2 = "Assets/" + f.filnavn[i] + ".json";
    StreamReader tt = new StreamReader(path2);
    string temp2 = tt.ReadToEnd();
    tt.Close();
    player = JsonUtility.FromJson<Charactervariable>(temp2);
}

}