using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform target;
    public float rotateSpeed = 90f;
    public float stepDelay = 0.2f;
    private float stepTimer = 0f;

    void Update()
    {
        if (target == null) return;

        // Vector từ turret đến target
        Vector3 direction = target.position - transform.position;
        direction.y = 0f; // xoay trên mặt phẳng

        if (direction == Vector3.zero) return;

        // Góc xoay mong muốn
        Quaternion targetRotation = Quaternion.LookRotation(direction);

        // XOAY DỰT DỰT (step by step)
        stepTimer += Time.deltaTime;
        if (stepTimer >= stepDelay)
        {
            stepTimer = 0f;
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                targetRotation,
                rotateSpeed * Time.deltaTime
            );
        }
    }
}
