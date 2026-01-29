using UnityEngine;
using UnityEngine.Video;

public class IntroCutsceneController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public AudioSource musicSource;
    public GameObject skipUI;          // UI chứa nút Skip
    public GameObject introObjects;    // Màn hình/video intro (nếu có)
    public GameObject gameplayGroup;   // Nhóm gameplay (Cube, Camera, Ground)

    void Start()
    {
        skipUI.SetActive(false);
        gameplayGroup.SetActive(false);   // Ẩn gameplay lúc đầu

        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        videoPlayer.Prepare();
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        videoPlayer.Play();
        musicSource.Play();
        skipUI.SetActive(true);
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        EndIntro();
    }

    public void SkipIntro()
    {
        EndIntro();
    }

    void EndIntro()
    {
        videoPlayer.Stop();
        musicSource.Stop();

        skipUI.SetActive(false);

        if (introObjects != null)
            introObjects.SetActive(false);   // Ẩn màn intro (video, canvas...)

        gameplayGroup.SetActive(true);      // HIỆN GAMEPLAY 🎮
    }
}
