using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    private Portal1 portal1 = new Portal1();
    private Portal2 portal2 = new Portal2();
    private Portal3 portal3 = new Portal3();
    private Portal4 portal4 = new Portal4();

    private GameObject SelectFriend()
    {
        switch (GlobalVariables.FriendObject)
        {
            case "ship1":
                if (GlobalVariables.Coins < GlobalVariables.Ship1Cost) return null;
                GlobalVariables.Coins -= GlobalVariables.Ship1Cost;
                return GlobalVariables.PrefabShip1;

            case "ship2":
                if (GlobalVariables.Coins < GlobalVariables.Ship2Cost) return null;
                GlobalVariables.Coins -= GlobalVariables.Ship2Cost;
                return GlobalVariables.PrefabShip2;

            case "ship3":
                if (GlobalVariables.Coins < GlobalVariables.Ship3Cost) return null;
                GlobalVariables.Coins -= GlobalVariables.Ship3Cost;
                return GlobalVariables.PrefabShip3;

            case "shield":
                if (GlobalVariables.Coins < GlobalVariables.ShieldCost) return null;
                GlobalVariables.Coins -= GlobalVariables.ShieldCost;
                return GlobalVariables.PrefabShield;

            case "generator":
                if (GlobalVariables.Coins < GlobalVariables.GeneratorCost) return null;
                GlobalVariables.Coins -= GlobalVariables.GeneratorCost;
                return GlobalVariables.PrefabGeneratorEmpty;
        }

        return null;
    }

    public GameObject Friend(Vector3 position)
    {
        GameObject selectedFriend = SelectFriend();
        if (selectedFriend == null) return null; 

        GameObject spawnedPrefab = Instantiate(selectedFriend);
        spawnedPrefab.transform.position = position;

        return spawnedPrefab; 
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

    public void GeneratorFull(Vector3 position)
    {
        GameObject spawnedObject = Instantiate(GlobalVariables.PrefabGeneratorFull);
        spawnedObject.transform.position = position;
    }

    public void GeneratorEmpty(Vector3 position)
    {
        GameObject spawnedObject = Instantiate(GlobalVariables.PrefabGeneratorEmpty);
        spawnedObject.transform.position = position;
    }

    private void RandomPortals()
    {
        int portal2Active = Random.Range(1, 5);

        switch (portal2Active)
        {
            case 1:
                portal1.Spawn();
                return;

            case 2:
                portal2.Spawn();
                return;

            case 3:
                portal3.Spawn();
                return;

            case 4:
                portal4.Spawn();
                return;
        }
    }

    public void ActiveRandomPortals()
    {
        StartCoroutine(Portals());
    }

    IEnumerator Portals()
    {
        while (true)
        {
            RandomPortals();
            yield return new WaitForSeconds(GlobalVariables.EnemiesTime);
        }
    }
}
