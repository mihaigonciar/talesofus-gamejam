using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S12Controller : MonoBehaviour
{
    public SceneController Controller;

    public Animator SceneAnimator;

    public string Prompt1 = "Finally! The test began...";
    public string Prompt2 = "... and the boy was successful, and now had his Dragon!";

    private void Start()
    {
        //SoundManager.Instance.SetAmbiance(Ambiance.Baby);
    }

    public void TriggerEndScene()
    {
        SceneAnimator.SetTrigger("Action");
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
