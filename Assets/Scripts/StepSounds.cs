using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StepSounds : MonoBehaviour
{
    private PlayerController _playerController;
    private AudioSource _audioSource;
    private int _random = 0;

    public AudioClip[] Collection;

    private void Start()
    {
        _playerController = this.GetComponent<PlayerController>();
        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_playerController.IsMoving)
        {
            if (_audioSource.isPlaying)
            {
                // nimic
            }
            else
            {
                PlaySound();
            }
        }
    }

    private void PlaySound()
    {
        int i;

        do
        {
            i = Random.Range(0, Collection.Length);
        } while (_random == i);

        _random = i;

        _audioSource.clip = Collection[_random];
        _audioSource.Play();
    }
}
