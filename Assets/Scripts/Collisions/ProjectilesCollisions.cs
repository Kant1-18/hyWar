using UnityEngine;
using System.Collections.Generic;

public class ProjectilesCollisions : MonoBehaviour
{
    public float collisionThreshold = 0.5f; // Define how close objects should be to count as a collision

    void Update()
    {
        GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy1");
        List<GameObject> allEnemies = new List<GameObject>(enemies);

        allEnemies.AddRange(GameObject.FindGameObjectsWithTag("Enemy2"));
        allEnemies.AddRange(GameObject.FindGameObjectsWithTag("Enemy3"));

        foreach (GameObject enemy in allEnemies)
        {
            if (Vector3.Distance(transform.position, enemy.transform.position) < collisionThreshold)
            {
                Destroy(enemy); // Destroy enemy
                Destroy(gameObject); // Destroy projectile
                break; // Exit loop to prevent destroying multiple enemies at once
            }
        }
    }
}
