using UnityEngine;

public class BulletMover : MonoBehaviour
{
    public float speed = 20f;
    public int damage = 1;

    void Start()
    {
        Destroy(gameObject, 3f); // tự hủy sau 3s
    }

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // tìm EnemyHealth ở object hoặc parent
        EnemyHealth enemy = collision.GetComponentInParent<EnemyHealth>();

        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}