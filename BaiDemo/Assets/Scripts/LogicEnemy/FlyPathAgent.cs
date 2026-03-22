using UnityEngine;

public class FlyPathAgent : MonoBehaviour
{
    public FlyPath path;
    public float speed = 5f;
    private int currentStep = 0;

    void Update() {
        if (path == null || currentStep >= path.Length) return;

        Vector3 targetPos = path[currentStep];
        transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        Vector3 dir = targetPos - transform.position;
        if (dir != Vector3.zero) {
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward); 
        }

        if (Vector3.Distance(transform.position, targetPos) < 0.1f) {
            currentStep++;
            if (currentStep >= path.Length) {
                Destroy(gameObject);
            }
        }
    }
}