using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip hurtSound;

    // Public method binding
    public void PlayHurtSound(float normalizedHealth)
    {
        if (audioSource != null && hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound);
        }
    }
}