using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class DrawMechanicTrigger : MonoBehaviour
{
    public GameObject SpellTomeButton;

    private void Start()
    {
        SpellTomeButton.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpellTomeButton.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            SpellTomeButton.SetActive(false);
        }
    }
}
