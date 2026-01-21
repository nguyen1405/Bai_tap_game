using UnityEngine;

public class TargetMove : MonoBehaviour
{
    private Vector3 startPosition = new Vector3(0, 0.5f, 0);
    private bool moveCircle = true;

    void Update()
    {
        // Nhấn R để target quay về vị trí ban đầu
        if (Input.GetKeyDown(KeyCode.R))
        {
            moveCircle = !moveCircle;
            Debug.Log("Target movement: " + (moveCircle ? "Circular" : "Fixed at origin"));
        }

        if (moveCircle)
        {
            // Di chuyển vòng tròn
            float x = Mathf.Sin(Time.time) * 3f;
            float z = Mathf.Cos(Time.time) * 3f;
            transform.position = new Vector3(x, 0.5f, z);
        }
        else
        {
            // Ở vị trí gốc
            transform.position = startPosition;
        }
    }
}
