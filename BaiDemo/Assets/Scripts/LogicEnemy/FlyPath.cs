using UnityEngine;

public class FlyPath : MonoBehaviour
{
    public Transform[] waypoints;

    private void OnDrawGizmos() {
        if (waypoints == null || waypoints.Length < 2) return;

        Gizmos.color = Color.cyan;
        for (int i = 0; i < waypoints.Length - 1; i++) {
            if (waypoints[i] != null && waypoints[i+1] != null) {
                Gizmos.DrawLine(waypoints[i].position, waypoints[i+1].position);
            }
        }
    }

    public Vector3 this[int index] {
        get { return waypoints[index].position; }
    }

    public int Length => waypoints.Length;
}