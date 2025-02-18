using UnityEngine;
using System.Collections;

public class Portal3 : MonoBehaviour
{
    private Spawner spawner;

    void Start()
    {
        while (true)
        {
            if (GlobalVariables.isActivePortal3) break;
        }

        SpawnObject();

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
