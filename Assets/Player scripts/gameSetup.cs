using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class gameSetup : MonoBehaviour
{
    public Image p1;
    public Image p2;
    public Image p3;
    public Image p4;

    public TMP_Text t1;
    public TMP_Text t2;
    public TMP_Text t3;
    public TMP_Text t4;

    public Slider hp1;
    public Slider hp2;
    public Slider hp3;
    public Slider hp4;
    public Slider mp1;
    public Slider mp2;
    public Slider mp3;
    public Slider mp4;

    public Party p;

    void Start()
    {
        string path = "Assets/" + PlayerPrefs.GetString("Cparty") + ".json";
        StreamReader t = new StreamReader(path);
        string temp = t.ReadToEnd();
        t.Close();
        p = JsonUtility.FromJson<Party>(temp);

        p1.sprite = (Sprite)Resources.Load(p.c1.assetsName, typeof(Sprite));
        p2.sprite = (Sprite)Resources.Load(p.c2.assetsName, typeof(Sprite));
        p3.sprite = (Sprite)Resources.Load(p.c3.assetsName, typeof(Sprite));
        p4.sprite = (Sprite)Resources.Load(p.c4.assetsName, typeof(Sprite));

        t1.text = "" + p.c1.role;
        t2.text = "" + p.c2.role;
        t3.text = "" + p.c3.role;
        t4.text = "" + p.c4.role;

        hp1.maxValue = p.c1.health;
        hp1.value = p.c1.maxhealth;
        hp2.maxValue = p.c2.health;
        hp2.value = p.c2.maxhealth;
        hp3.maxValue = p.c3.health;
        hp3.value = p.c3.maxhealth;
        hp4.maxValue = p.c4.health;
        hp4.value = p.c4.maxhealth;

        mp1.maxValue = p.c1.health;
        mp1.value = p.c1.maxhealth;
        mp2.maxValue = p.c2.health;
        mp2.value = p.c2.maxhealth;
        mp3.maxValue = p.c3.health;
        mp3.value = p.c3.maxhealth;
        mp4.maxValue = p.c4.health;
        mp4.value = p.c4.maxhealth;
    }

    void Update(){}

}
