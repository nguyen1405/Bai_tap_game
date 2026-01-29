using UnityEngine;

public class GlobalAudio : MonoBehaviour
{
    void Update()
    {
        // M: Mute/Unmute
        if (Input.GetKeyDown(KeyCode.M))
        {
            AudioListener.volume = AudioListener.volume > 0f ? 0f : 1f;
            Debug.Log("Global Volume: " + AudioListener.volume);
        }

        // P: Pause/Resume
        if (Input.GetKeyDown(KeyCode.P))
        {
            AudioListener.pause = !AudioListener.pause;
            Debug.Log("Global Pause: " + AudioListener.pause);
        }
    }
}