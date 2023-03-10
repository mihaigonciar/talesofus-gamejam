using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3CanvasController : MonoBehaviour
{
    public SpriteRenderer Player;
    public GameObject Enemy;
    public GameObject KidnappedBOdy;
    public GameObject Kart;
    public SceneController Controller;

    private void Start()
    {
        Player.enabled = true;
        Enemy.SetActive(false);
        KidnappedBOdy.SetActive(false);
        Kart.SetActive(true);
    }

    /// <summary>
    /// Solomonari appears behind player
    /// </summary>
    public void Flash1()
    {
        Enemy.SetActive(true);
    }

    /// <summary>
    /// Player is put in cart
    /// </summary>
    public void Flash2()
    {
        Enemy.SetActive(false);
        Player.enabled = false;
        KidnappedBOdy.SetActive(true);
        this.GetComponent<AudioSource>().Play();
    }

    /// <summary>
    /// Cart leaves.
    /// </summary>
    public void Flash3()
    {
        Kart.SetActive(false);
    }

    public void GoToScene()
    {
        SoundManager.Instance.StopAmbiance();
        Controller.GoToNextScene();
    }
}
