using UnityEngine;

public class PushObject3D : MonoBehaviour
{
    public float force = 5f;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("SPACE presssssss");
            rb.AddForce(Vector3.right * force, ForceMode.Impulse);
        }
    }
}
