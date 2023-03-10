using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SceneController : MonoBehaviour
{
    public Scenes NextScene;
    public TransitionTexts PromptSource;

    private void Start()
    {
        bool isTransitionScene = false;

        string sceneName = SceneManager.GetActiveScene().name.ToString();

        if (sceneName.Contains("Transition"))
        {
            isTransitionScene = true;
        }

        if (isTransitionScene)
        {
            TextMeshProUGUI text = GameObject.Find("Prompt Text").GetComponent<TextMeshProUGUI>();

            switch (sceneName)
            {
                case nameof(Scenes.S0_Transition):
                    {
                        text.text = PromptSource.Transition_S0_Text;
                        break;
                    }
                case nameof(Scenes.S2_Transition):
                    {
                        text.text = PromptSource.Transition_S2_Text;
                        break;
                    }
                case nameof(Scenes.S4_Transition):
                    {
                        text.text = PromptSource.Transition_S4_Text;
                        break;
                    }
                case nameof(Scenes.S5_Transition):
                    {
                        text.text = PromptSource.Transition_S5_Text;
                        break;
                    }
                case nameof(Scenes.S7_Transition):
                    {
                        text.text = PromptSource.Transition_S7_Text;
                        break;
                    }
                case nameof(Scenes.S9_Transition):
                    {
                        text.text = PromptSource.Transition_S9_Text;
                        break;
                    }
                case nameof(Scenes.S11_Transition):
                    {
                        text.text = PromptSource.Transition_S11_Text;
                        break;
                    }
                case nameof(Scenes.S13_Transition):
                    {
                        text.text = PromptSource.Transition_S13_Text;
                        break;
                    }
            }
        }
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene(NextScene.ToString());
    }
}

public enum Scenes
{
    MainMenu,
    S1_Intro,
    S2_Transition,
    S3_Kidnap,
    S4_Transition,
    S5_Transition,
    S6_Spell1,
    S7_Transition,
    S8_Spell2,
    S9_Transition,
    S10_Spell3,
    S11_Transition,
    S0_Transition,
    S12_Outro,
    S13_Transition
}
