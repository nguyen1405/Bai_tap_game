using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Va chạm với: " + collision.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Đi vào vùng Trigger của: " + other.gameObject.name);
    }
}
