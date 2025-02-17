using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemiesPrefabs;
    [SerializeField] private Transform[] spawnPortals;

    public float enemySpawnTime = 2f;
    public float enemySpeed = 2f;

    private float timeUntilSpawn;

    private void Update()
    {
        SpawnLoop();
    }

    private void SpawnLoop()
    {
        timeUntilSpawn += Time.deltaTime;

        if (timeUntilSpawn >= enemySpawnTime)
        {
            Spawn();
            timeUntilSpawn = 0;
        }
    }

    private void Spawn()
    {
        //random select enemies
        GameObject enemyToSpawn = enemiesPrefabs[Random.Range(0, enemiesPrefabs.Length)];
        //random select a portal
        Transform randomPortal = spawnPortals[Random.Range(0, spawnPortals.Length)];
        //spawn with the prefab rotation
        GameObject spawnedEnemy = Instantiate(enemyToSpawn, randomPortal.position, Quaternion.identity);

        MoveEnemy mover = spawnedEnemy.GetComponent<MoveEnemy>();
        if (mover == null)
        {
            mover = spawnedEnemy.AddComponent<MoveEnemy>();
        }

        mover.speed = enemySpeed; 
    }
}
