using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public Animator DiffuseAnimator;

    private void Start()
    {
        OnScreenHelper.Instance.DisableHelper();
        SoundManager.Instance.SetMusic(MusicGenre.Folk);
    }

    public Scenes FirstScene = Scenes.S0_Transition;
    /// <summary>
    /// Method that starts the game.
    /// </summary>
    public void GoToGameScene()
    {
        DiffuseAnimator.SetTrigger("Action");
    }

    public void GoToScene()
    {
        SceneManager.LoadScene(FirstScene.ToString());
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
