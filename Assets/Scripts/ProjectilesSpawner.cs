using UnityEngine;

public class ProjectilesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] projectilesPrefabs;
    [SerializeField] private Transform[] spawnPortals;

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
        //random select portal
        Transform randomPortal = spawnPortals[Random.Range(0, spawnPortals.Length)];
        //spawn with the prefab rotation
        GameObject spawnedProjectiles = Instantiate(projectilesToSpawn, randomPortal.position, Quaternion.identity);
    }
}

