using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S3WellController : MonoBehaviour
{
    private bool _isInUse = false;
    private PlayerController _player;

    public bool CanInteract = false;

    public string ToolTipMessage = "Press E to get water from the well.";

    public Animator CanvasAnimator;
    private void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && CanInteract)
        {
            if (!_isInUse)
            {
                _isInUse = true;

                // Additional Code

                // Disrupt player from moving
                _player.CanBeControlled = false;

                // Hide Helper
                OnScreenHelper.Instance.DisableHelper();

                CanvasAnimator.SetTrigger("Action");
                // Go to next scene
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CanInteract = true;
            OnScreenHelper.Instance.SetMessage(ToolTipMessage);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CanInteract = false;
            OnScreenHelper.Instance.RollBackMessage();
        }
    }
}
