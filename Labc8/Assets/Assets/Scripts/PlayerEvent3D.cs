using UnityEngine;

public class Events3D : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("[Collision] Hit: " + col.gameObject.name);
    }

    void OnTriggerEnter(Collider col)
    {
        Debug.Log("[Trigger] Enter: " + col.gameObject.name);
    }
}
