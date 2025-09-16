using UnityEngine;

public class InputManager : MonoBehaviour
{
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AudioManager.Instance.ChangeMusic(AudioManager.SoundType.Music_Menu);
        }
        else if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            AudioManager.Instance.ChangeMusic(AudioManager.SoundType.Music_Menu);
        }
    }
}
