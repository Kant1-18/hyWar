using UnityEngine;
using System.Collections;

public class Portal3 : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    void Update()
    {
        if (GlobalVariables.isActivePortal3) SpawnObject();
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
