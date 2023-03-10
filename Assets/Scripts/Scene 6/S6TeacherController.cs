using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S6TeacherController : MonoBehaviour
{
    private bool _didInteraction1 = false;
    private PlayerController _player;

    public string Message1 = "There are times when you can reward others...";
    public float Message1Timer = 3f;
    public string Message2 = "Now show me how you bring bountiful rain!";
    public float Message2Timer = 3f;

    private void ActOne()
    {
        _didInteraction1 = true;
        StartCoroutine(HandleActOne());
    }

    private IEnumerator HandleActOne()
    {
        _player.CanBeControlled = false;

        OnScreenHelper.Instance.SetMessage(Message1);
        yield return new WaitForSeconds(Message1Timer);
        
        
        OnScreenHelper.Instance.SetMessage(Message2);
        yield return new WaitForSeconds(Message2Timer);

        this.transform.localScale = new Vector3(this.transform.localScale.x * -1, this.transform.localScale.y, this.transform.localScale.z);

        OnScreenHelper.Instance.DisableHelper();
        _player.CanBeControlled = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (_didInteraction1 == false)
            {
                _player = collision.gameObject.GetComponent<PlayerController>();

                ActOne();
            }
        }
    }
}
