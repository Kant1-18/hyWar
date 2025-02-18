using UnityEngine;
using System.Collections;

public class Portal4 : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            SpawnGameObject();
            yield return new WaitForSeconds(GlobalVariables.EnemiesTime);
        }
    }

    void SpawnGameObject()
    {
        spawner.Enemy(transform.position);
    }
}
