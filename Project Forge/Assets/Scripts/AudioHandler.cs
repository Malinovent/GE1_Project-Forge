using UnityEngine;

public class AudioHandler : MonoBehaviour
{
    [SerializeField] private AudioClip audioClip;

    public void PlaySound()
    {
        AudioManager.Singleton.Play(audioClip);
    }
}
