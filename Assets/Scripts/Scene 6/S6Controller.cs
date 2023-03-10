using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class S6Controller : MonoBehaviour
{
    public GameObject DrawableArea;
    public GameObject InstructableCanvas;
    public GameObject TomeButton;

    public Animator SceneAnimator;

    private SceneController _sceneController;
    private PlayerController _playerController;

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

        _sceneController = this.GetComponent<SceneController>();
        _playerController = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

        DrawableArea.SetActive(false);
        InstructableCanvas.SetActive(false);
    }

    public void EnableActivity()
    {
        _playerController.CanBeControlled = false;

        DrawableArea.SetActive(true);
        InstructableCanvas.SetActive(true);
        TomeButton.SetActive(false);
    }

    public void CompleteActivity()
    {
        SceneAnimator.SetTrigger("Action");
        DrawableArea.SetActive(false);
        InstructableCanvas.SetActive(false);
    }
}
