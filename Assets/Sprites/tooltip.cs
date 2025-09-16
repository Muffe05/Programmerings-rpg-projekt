using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class tooltip : MonoBehaviour
{
    public GameObject o;
    public Items item;
    public Image pImage;
    public TMP_Text name;
    public TMP_Text type;
    public TMP_Text damage;
    public TMP_Text defence;
    public TMP_Text durability;
    public TMP_Text description;


    public void Hover() {

        string path = "Assets/"+ this.GetComponent<Image>().sprite.name+".json";
        StreamReader t = new StreamReader(path);
        string json = t.ReadToEnd();
        t.Close();
        item = JsonUtility.FromJson<Items>(json);
        o.SetActive(true);
        pImage.GetComponent<Image>().sprite = this.GetComponent<Image>().sprite;
        name.GetComponent<TMP_Text>().text = this.GetComponent<Image>().sprite.name;
        type.text = "Type : "+ item.t;
        if (item.damage == 0)
            damage.text = "";
        else
            damage.text = "Damage : " + item.damage;
        if (item.defence == 0)
            defence.text = "";
        else
            defence.text = "Defence : " + item.defence;
        durability.text = "Durability : " + item.durability;
        description.text = "Description : " + item.description;
            Debug.Log(this.GetComponent<Image>().sprite.name);
    }

    public void HoverExit()
    {
        o.SetActive(false);
    }
}
