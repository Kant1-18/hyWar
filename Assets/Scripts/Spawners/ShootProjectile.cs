using UnityEngine;
using System.Collections;

public class NewMonoBehaviour : MonoBehaviour
{
    public GameObject projectile;

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            SpawnGameObject();
            yield return new WaitForSeconds(1);
        }
    }

    void SpawnGameObject()
    {
        GameObject spawnedPrefab = Instantiate(projectile);
        spawnedPrefab.transform.position = transform.position;
    }
}
