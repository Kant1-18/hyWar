using UnityEngine;

public class ProjectilesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] projectilesPrefabs;

    public float projectilesSpawnTime = 2f;

    private float timeUntilSpawn;

    private void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        timeUntilSpawn += Time.deltaTime;

        if (timeUntilSpawn >= projectilesSpawnTime)
        {
            Spawn();
            timeUntilSpawn = 0;
        }
    }

    private void Spawn()
    {
        GameObject projectilesToSpawn = projectilesPrefabs[Random.Range(0, projectilesPrefabs.Length)];
        
        //spawn with the prefab rotation
        GameObject spawnedProjectiles = Instantiate(projectilesToSpawn, transform.position, Quaternion.identity);
    }
}

