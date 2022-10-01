using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    public AudioSource AmbianceMusic;
    public AudioSource BackgroundMusic;

    public AudioClip VillageAmbiance;
    public AudioClip CaveAmbiance;
    public AudioClip ForrestAmbiance;

    public AudioClip FolkMusic;
    public AudioClip SuspensefulMusic;
    public AudioClip FantasyMusic;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(this);
    }

    public void SetAmbiance(Ambiance ambiance)
    {
        AudioClip clip = null;

        switch (ambiance)
        {
            case Ambiance.Village:
                {
                    clip = VillageAmbiance;
                    break;
                }
            case Ambiance.Cave:
                {
                    clip = CaveAmbiance;
                    break;
                }
            case Ambiance.Forrest:
                {
                    clip = ForrestAmbiance;
                    break;
                }
        }

        if (AmbianceMusic.isPlaying)
        {
            AmbianceMusic.Stop();
        }

        if (clip != null)
        {
            AmbianceMusic.clip = clip;
            AmbianceMusic.Play();
        }
    }

    public void StopAmbiance()
    {
        if (AmbianceMusic.isPlaying)
        {
            AmbianceMusic.Stop();
        }
    }

    public void SetMusic(MusicGenre genre)
    {
        AudioClip clip = null;

        switch (genre)
        {
            case MusicGenre.Folk:
                {
                    clip = FolkMusic;
                    break;
                }
            case MusicGenre.Suspenseful:
                {
                    clip = SuspensefulMusic;
                    break;
                }
            case MusicGenre.Fantasy:
                {
                    clip = FantasyMusic;
                    break;
                }
        }

        if (BackgroundMusic.isPlaying)
        {
            BackgroundMusic.Stop();
        }

        if (clip != null)
        {
            BackgroundMusic.clip = clip;
            BackgroundMusic.Play();
        }
    }

    public void StopMusic()
    {
        if (BackgroundMusic.isPlaying)
        {
            BackgroundMusic.Stop();
        }
    }
}

public enum Ambiance
{
    Village,
    Forrest,
    Cave
}

public enum MusicGenre
{
    Folk,
    Suspenseful,
    Fantasy
}
