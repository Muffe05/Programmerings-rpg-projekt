using UnityEngine;
using UnityEngine.UI;

public class Encounter : MonoBehaviour
{
    public Enemy e;
    public Slider hp;
    public Image img;

    private void Awake()
    {
        e.health = e.maxhealth;
    }

    void Start()
    {
        hp.maxValue = e.maxhealth;
        img.sprite = e.s;
    }

    void Update()
    {
        hp.value = e.health;
    }

    public void takeDamage(int i)
    {
        e.health -= i;
    }
}
