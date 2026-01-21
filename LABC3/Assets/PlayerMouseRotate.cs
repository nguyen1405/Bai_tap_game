using UnityEngine;
using UnityEngine.UI;

public class PlayerMouseRotate : MonoBehaviour
{
    public Camera mainCamera;
    public Text angleText;

    void Update()
    {
        if (mainCamera == null || angleText == null) return;

        // Ray từ chuột xuống mặt đất
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Vector3 targetPos = hit.point;
            targetPos.y = transform.position.y;

            // Hướng từ Player tới chuột
            Vector3 direction = targetPos - transform.position;

            // Xoay Player theo chuột
            transform.rotation = Quaternion.LookRotation(direction);

            // Tính Signed Angle (theo trục Y)
            float angle = Vector3.SignedAngle(
                Vector3.forward,
                direction,
                Vector3.up
            );

            angleText.text = "Angle: " + angle.ToString("F1") + "°";
        }
    }
}
