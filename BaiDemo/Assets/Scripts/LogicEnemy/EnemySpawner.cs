using UnityEngine;
using System.Collections;

[System.Serializable]
public class WaveInfo {
    public GameObject enemyPrefab;
    public int count;
    public float spawnInterval;
    public FlyPath path;
    public float speed;
}

public class EnemySpawner : MonoBehaviour 
{
    public WaveInfo[] waves;
    private int currentWave = 0;

    void Start() {
        StartCoroutine(SpawnAllWaves());
    }

    IEnumerator SpawnAllWaves() {
        foreach (WaveInfo wave in waves) {
            for (int i = 0; i < wave.count; i++) {
                SpawnEnemy(wave);
                yield return new WaitForSeconds(wave.spawnInterval);
            }
            yield return new WaitForSeconds(2f);
        }
    }

    void SpawnEnemy(WaveInfo info) {
        GameObject enemy = Instantiate(info.enemyPrefab, info.path[0], Quaternion.identity);
        FlyPathAgent agent = enemy.GetComponent<FlyPathAgent>();
        agent.path = info.path;
        agent.speed = info.speed;
    }
}