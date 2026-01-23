using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
public GameObject bulletPrefab;

void Update()
{
if (Input.GetMouseButtonDown(0))
{
Instantiate(bulletPrefab, transform.position,
transform.rotation);
}
}
}
