using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 6f;
    Rigidbody2D rb;

    void Awake() => rb = GetComponent<Rigidbody2D>();

    void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        Vector2 dir = new Vector2(x, y).normalized;

        rb.velocity = dir * speed;
    }
}
