using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    private GameObject SelectFriend()
    {
        switch (GlobalVariables.FriendObject)
        {
            case "ship1":
                return GlobalVariables.PrefabShip1;

            case "ship2":
                return GlobalVariables.PrefabShip2;

            case "ship3":
                return GlobalVariables.PrefabShip2;

            case "shield":
                return GlobalVariables.PrefabShip2;

            case "generator":
                return GlobalVariables.PrefabShip2;
        }

        return null;
    }

    public void Friend()
    {
        GameObject spawnedPrefab = Instantiate(SelectFriend());
        spawnedPrefab.transform.position = transform.position;
    }

    private GameObject SelectEnemy(int difficulty)
    {
        int randomPrefab;

        if (difficulty == 2)
        {
            randomPrefab = Random.Range(1, 2);
        }
        else if (difficulty == 3)
        {
            randomPrefab = Random.Range(1, 3);
        }
        else
        {
            randomPrefab = 1;
        }

        switch (randomPrefab)
        {
            case 1:
                return GlobalVariables.PrefabEnemy1;

            case 2:
                return GlobalVariables.PrefabEnemy2;

            case 3:
                return GlobalVariables.PrefabEnemy3;
        }

        return null;
    }

    public void Enemy(Vector3 position)
    {
        GameObject spawnedObject = Instantiate(SelectEnemy(GlobalVariables.Difficulty));
        spawnedObject.transform.position = position;
    }
}
