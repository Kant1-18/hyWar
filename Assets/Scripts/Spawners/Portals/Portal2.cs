using UnityEngine;
using System.Collections;

public class Portal2 : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    void Update()
    {
        if (GlobalVariables.isActivePortal4) SpawnObject();
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
