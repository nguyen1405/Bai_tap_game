using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 12f;
    public float lifeTime = 3f;
    public int damage = 10;

    public bool destroyOnHit = true;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        if (rb != null)
            rb.velocity = (Vector2)transform.right * speed;

        Destroy(gameObject, lifeTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        var playerHealth = other.GetComponent<PlayerHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            if (destroyOnHit) Destroy(gameObject);
        }
        else if (destroyOnHit && (other.CompareTag("Wall") || other.CompareTag("Ground")))
        {
            Destroy(gameObject);
        }
    }
}
