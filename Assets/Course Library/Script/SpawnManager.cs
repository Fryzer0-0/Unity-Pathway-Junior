using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    public GameObject powerupPrefab;
    private float SpawnRange = 9.0f;
    public int enemyCount;
    public int waveNumber = 1;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        SpawnEnemyWave(waveNumber);
        Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        enemyCount = FindObjectsByType<Enemy>(FindObjectsSortMode.None).Length;

        if (enemyCount == 0)
        {
            waveNumber++;
            SpawnEnemyWave(waveNumber);
            Instantiate(powerupPrefab, GenerateSpawnPosition(), powerupPrefab.transform.rotation);
        }
        
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnRangeX = Random.Range(-SpawnRange, SpawnRange);
        float spawnRangeZ = Random.Range(-SpawnRange, SpawnRange);

        return new Vector3(spawnRangeX, 0, spawnRangeZ);
    }
}
