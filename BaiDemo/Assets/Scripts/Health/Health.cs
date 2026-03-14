using UnityEngine;
using System;

public class Health : MonoBehaviour
{
    public GameObject explosionPrefab;
    public int defaultHealthPoint = 5;

    protected int healthPoint;

    public Action onHealthChanged;
    public Action OnDead;

    protected virtual void Awake()
    {
        healthPoint = defaultHealthPoint;
    }

    protected virtual void Die()
    {
        OnDead?.Invoke();

        if (explosionPrefab != null)
        {
            var explosion = Instantiate(explosionPrefab, transform.position, transform.rotation);
            Destroy(explosion, 1f);
        }

        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        if (healthPoint <= 0) return;

        healthPoint -= damage;

        onHealthChanged?.Invoke();

        if (healthPoint <= 0)
        {
            Die();
        }
    }

    public float GetHealthPercent()
    {
        return (float)healthPoint / defaultHealthPoint;
    }
}