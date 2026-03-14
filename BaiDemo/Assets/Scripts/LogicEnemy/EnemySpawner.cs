using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnRate = 3f;

    public float spawnX = 4f;

    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 1f, spawnRate);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-spawnX, spawnX);

        Vector3 spawnPos = new Vector3(randomX, transform.position.y, 0);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
}