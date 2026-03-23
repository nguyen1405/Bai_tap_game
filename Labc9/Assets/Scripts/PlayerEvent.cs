using UnityEngine;

public class PlayerEvents : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("[Collision2D] Hit: " + col.gameObject.name);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("[Trigger2D] Enter: " + col.gameObject.name);
    }
}
