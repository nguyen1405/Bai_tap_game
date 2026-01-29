using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoEventController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject finishUI; // Panel hoặc Text/Nút hiện khi video xong

    void Start()
    {
        // Đăng ký sự kiện
        videoPlayer.prepareCompleted += OnVideoPrepared;
        videoPlayer.loopPointReached += OnVideoFinished;

        finishUI.SetActive(false); // Ẩn UI lúc đầu
        videoPlayer.Prepare();     // Chuẩn bị video
    }

    void OnVideoPrepared(VideoPlayer vp)
    {
        Debug.Log("Video đã load xong, bắt đầu phát");
        vp.Play();
    }

    void OnVideoFinished(VideoPlayer vp)
    {
        Debug.Log("Video đã phát xong!");
        finishUI.SetActive(true); // Hiện chữ hoặc nút
    }

    public void GoToNextScene()
    {
        SceneManager.LoadScene("Scene2"); // đổi tên scene của bạn
    }
}
