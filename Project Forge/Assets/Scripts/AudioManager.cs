using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    // private AudioSource audioSource;

    [SerializeField] List<AudioSource> audioSources = new List<AudioSource>();

    /// <summary>
    /// Singleton
    /// </summary>

    public static AudioManager Singleton;

    private void Awake()
    {

        if (Singleton == null)
        {
            Singleton = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

        DontDestroyOnLoad(this.gameObject);
    }

    public void Play(AudioClip audioClip)
    {
        foreach(AudioSource audioSource in audioSources)
        {
            if(audioSource.isPlaying == false)
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                return;
            }
        }

        AudioSource newAudioSource = this.gameObject.AddComponent<AudioSource>();
        newAudioSource.clip = audioClip;
        newAudioSource.Play();
        audioSources.Add(newAudioSource);
    }
}
