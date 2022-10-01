using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S3Controller : MonoBehaviour
{
    public string Message1 = "Mom asked me to bring water from the well...";

    public Animator SceneAnimator;

    void Start()
    {
        if (OnScreenHelper.Instance != null)
        {
            OnScreenHelper.Instance.SetMessage(Message1);
        }
        else
        {
            SceneManager.LoadScene(Scenes.MainMenu.ToString());
        }
    }
}
