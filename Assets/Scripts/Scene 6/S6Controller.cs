using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S6Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (OnScreenHelper.Instance == null)
        {
            SceneManager.LoadScene(Scenes.MainMenu.ToString());
            return;
        }
        else
        {
            SoundManager.Instance.SetMusic(MusicGenre.Fantasy);
            SoundManager.Instance.SetAmbiance(Ambiance.Cave);
        }
    }
}
