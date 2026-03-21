using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject enemyPrefab;
    private float SpawnRange = 9.0f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Vector3 GenerateSpawnPosition()
    {
        float spawnRangeX = Random.Range(-SpawnRange, SpawnRange);
        float spawnRangeZ = Random.Range(-SpawnRange, SpawnRange);

        return new Vector3(spawnRangeX, 0, spawnRangeZ);
    }
}
