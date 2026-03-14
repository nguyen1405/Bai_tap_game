using UnityEngine;

public class EnemyZigZag : MonoBehaviour
{
    public float speed = 3f;
    public float zigzagWidth = 2f;
    public float zigzagSpeed = 3f;
    public float stopY = 2f;

    float startX;
    float minX;
    float maxX;

    bool reachedPosition = false;

    EnemyShooter shooter;

    void Start()
    {
        startX = transform.position.x;
        shooter = GetComponent<EnemyShooter>();

        Camera cam = Camera.main;

        float height = cam.orthographicSize;
        float width = height * cam.aspect;

        minX = cam.transform.position.x - width + 0.5f;
        maxX = cam.transform.position.x + width - 0.5f;
    }

    void Update()
    {
        if (reachedPosition) return;

        float x = startX + Mathf.Sin(Time.time * zigzagSpeed) * zigzagWidth;

        // giới hạn trong camera
        x = Mathf.Clamp(x, minX, maxX);

        transform.position = new Vector3(
            x,
            transform.position.y - speed * Time.deltaTime,
            0
        );

        if (transform.position.y <= stopY)
        {
            reachedPosition = true;

            if (shooter != null)
                shooter.StartShooting();
        }
    }
}