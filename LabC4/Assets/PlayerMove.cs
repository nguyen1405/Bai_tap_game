using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 8f;  // Tốc độ di chuyển, bạn có thể chỉnh

    void Update()
    {
        // Lấy input từ phím WASD hoặc mũi tên
        float horizontal = Input.GetAxisRaw("Horizontal");   // A/D hoặc ← →
        float vertical   = Input.GetAxisRaw("Vertical");     // W/S hoặc ↑ ↓

        // Tạo hướng di chuyển
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // Di chuyển
        transform.position += direction * speed * Time.deltaTime;
    }
}