using UnityEngine;
using UnityEngine.UI;

public class outlineHover : MonoBehaviour
{
    public Material normal;
    public Material hover;
    public AudioClip meleeAttack;
    public AudioClip bowAttack;
    public AudioSource s;

    void Start()
    {
        this.gameObject.GetComponent<Image>().material = normal;
    }

    void Update()
    {

    }

    public void onPointerClick(int i) {
        Debug.Log("Click");
        if (i == 0)
            s.PlayOneShot(meleeAttack);
        else if (i == 1)
            s.PlayOneShot(bowAttack);
    }


    public void onPointerEnter() {
        this.gameObject.GetComponent<Image>().material = hover;
    }

    public void onPointerExit(){
        this.gameObject.GetComponent<Image>().material = normal;
    }

}



    