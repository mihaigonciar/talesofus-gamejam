using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActivityController : MonoBehaviour
{
    private int SpellCounter = 0;

    public TextMeshProUGUI TextBox;
    public GameObject ActivityObject;
    public Spells Spell;

    public string Message1 = "You are tasked to cast a positive spell. \n";
    public string Message2 = "Draw a Triangle shape 3 times on the next page. \n";

    public string OKMessage = "Good! Keep it going!";
    public string FinalMessage = "Congrats, young man. You are one step closer in your journey...";
    public string FailMessage = "<color=#ea0606>Your spell isn't good enough. Try again!</color>";

    public int MessageLimit = 10;

    private List<string> Messages = new List<string>();

    // Start is called before the first frame update
    void Start()
    {


        AddMessage(Message1);
        AddMessage(Message2);
    }

    public void ProcessSpell(string name, float score)
    {
        if (name == Spell.ToString())
        {
            if (score >= 0.85f)
            {
                SpellSuccess();
                return;
            }
        }

        SpellFail();
    }


    public void SpellSuccess()
    {
        SpellCounter++;

        if (SpellCounter > 2)
        {
            AddMessage(FinalMessage);
            StartCoroutine(FinishTest());
        }
        else
        {
            AddMessage(OKMessage);
        }
        
    }

    private IEnumerator FinishTest()
    {
        string scene = SceneManager.GetActiveScene().name;

        yield return new WaitForSeconds(3f);

        switch (scene)
        {
            case nameof(Scenes.S6_Spell1):
                {
                    S6Controller ctrl = GameObject.Find("Scene Controller").GetComponent<S6Controller>();
                    ctrl.CompleteActivity();
                    break;
                }
            case nameof(Scenes.S8_Spell2):
                {
                    S6Controller ctrl = GameObject.Find("Scene Controller").GetComponent<S6Controller>();
                    ctrl.CompleteActivity();
                    break;
                }
            case nameof(Scenes.S10_Spell3):
                {
                    S6Controller ctrl = GameObject.Find("Scene Controller").GetComponent<S6Controller>();
                    ctrl.CompleteActivity();
                    break;
                }
        }
    }

    public void SpellFail()
    {
        AddMessage(FailMessage);
    }

    private void AddMessage(string message)
    {
        Messages.Add(message);

        if (Messages.Count > MessageLimit)
        {
            Messages.RemoveAt(0);
        }

        TextBox.text = "";

        foreach(string msg in Messages)
        {
            TextBox.text += msg;
            TextBox.text += "\n";
        }
    }
}

public enum Spells
{
    Circle,
    Triangle,
    Star
}