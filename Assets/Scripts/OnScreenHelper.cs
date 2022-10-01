using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OnScreenHelper : MonoBehaviour
{
    public static OnScreenHelper Instance;

    public GameObject TextPanel;
    public TextMeshProUGUI TextBox;

    private List<string> _previousMessages = new List<string>();

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Instance.DisableHelper();
            Instance._previousMessages.Clear();
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this);
    }

    private void Start()
    {
        DisableHelper();
    }

    public void DisableHelper()
    {
        TextPanel.SetActive(false);
    }

    public void EnableHelper()
    {
        TextPanel.SetActive(true);
    }

    public void SetMessage(string message)
    {
        TextPanel.SetActive(true);
        _previousMessages.Add(message);
        TextBox.text = message;
    }

    public void RollBackMessage()
    {
        _previousMessages.RemoveAt(_previousMessages.Count - 1);
        TextBox.text = _previousMessages[^1];
        DisableHelper();
    }

}
