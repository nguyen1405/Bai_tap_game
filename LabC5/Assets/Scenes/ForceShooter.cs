using UnityEngine;

public class ForceShooter : MonoBehaviour
{
    public float forceAmount = 500f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(Vector3.forward * forceAmount);
        }
    }
}
