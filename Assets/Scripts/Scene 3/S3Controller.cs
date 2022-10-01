using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S3Controller : MonoBehaviour
{
    public string Message1 = "Mom asked me to bring water from the well...";

    void Start()
    {
        if (OnScreenHelper.Instance != null)
        {
            OnScreenHelper.Instance.SetMessage(Message1);
            SoundManager.Instance.SetAmbiance(Ambiance.Village);
        }
        else
        {
            SceneManager.LoadScene(Scenes.MainMenu.ToString());
        }
    }
}
