using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    public void Active()
    {
        switch (gameObject.name)
        {
            case "Portal1":
                if (GlobalVariables.isActivePortal1)
                {
                    SpawnObject();
                }
                return;

            case "Portal2":
                if (GlobalVariables.isActivePortal2)
                {
                    SpawnObject();
                }
                return;

            case "Portal3":
                if (GlobalVariables.isActivePortal3)
                {
                    SpawnObject();
                }
                return;

            case "Portal4":
                if (GlobalVariables.isActivePortal4)
                {
                    SpawnObject();
                }
                return;
        }
    }

    IEnumerator SpawnObject()
    {
        while (true)
        {
            SpawnGameObject();
            Debug.Log("test spawn enemy");
            yield return new WaitForSeconds(GlobalVariables.EnemiesTime);
        }
    }

    void SpawnGameObject()
    {
        spawner.Enemy(transform.position);
        GlobalVariables.isActivePortal1 = false;
        GlobalVariables.isActivePortal2 = false;
        GlobalVariables.isActivePortal3 = false;
        GlobalVariables.isActivePortal4 = false;

        spawner.ActiveRandomPortals();
    }
}
