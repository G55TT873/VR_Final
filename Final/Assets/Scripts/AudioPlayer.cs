using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource; // Assign the AudioSource in the Inspector

    public void PlaySound()
    {
        audioSource.Play();
    }
}
