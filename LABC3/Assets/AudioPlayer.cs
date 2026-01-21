using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioSource audioSource; // Kéo AudioSource vào đây
    public AudioClip hurtSound;     // Kéo file âm thanh .wav/.mp3 vào đây

    void Start()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged += PlayHurtSound;
        }
    }

    private void PlayHurtSound(float normalizedHealth)
    {
        // Chỉ phát khi bị trừ máu (có thể check normalized < trước đó, nhưng tạm đơn giản)
        if (audioSource != null && hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound);
        }
    }

    void OnDestroy()
    {
        PlayerHealth playerHealth = FindObjectOfType<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.OnHealthChanged -= PlayHurtSound;
        }
    }
}