using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextPromptAction : MonoBehaviour
{
    public SceneController Controller;
    public void TriggerSceneManager()
    {
        Controller.GoToNextScene();
    }
}
