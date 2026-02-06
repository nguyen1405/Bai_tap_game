using UnityEngine;

public class DetectHit : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("Collision với " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger với " + other.gameObject.name);
    }
}
