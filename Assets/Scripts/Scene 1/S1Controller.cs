using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S1Controller : MonoBehaviour
{
    public SceneController Controller;

    public string Prompt1 = "\"This is my baby boy!\" the young mother exclaimed!";
    public string Prompt2 = "...but the old Solomonari had their own plans...";

    private void Start()
    {
        SoundManager.Instance.SetAmbiance(Ambiance.Baby);
    }

    public void SetPrompt1()
    {
        OnScreenHelper.Instance.SetMessage(Prompt1);
    }
    public void SetPrompt2()
    {
        OnScreenHelper.Instance.SetMessage(Prompt2);
    }

    public void GoToScene()
    {
        Controller.GoToNextScene();
    }

    public void StopPrompt()
    {
        OnScreenHelper.Instance.DisableHelper();
    }
}
