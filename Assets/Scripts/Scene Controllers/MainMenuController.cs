using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    /// <summary>
    /// Method that starts the game.
    /// </summary>
    public void GoToGameScene()
    {
        SceneManager.LoadScene(Scenes.S1_Intro.ToString());
    }

    /// <summary>
    /// Quit method of the game.
    /// </summary>
    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
