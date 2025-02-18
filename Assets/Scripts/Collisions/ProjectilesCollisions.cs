using System.Runtime.CompilerServices;
using UnityEngine;

public class ProjectilesCollisions : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy1") || other.CompareTag("Enemy2") || other.CompareTag("Enemy3"))
        {
            Destroy(gameObject);
        }
    }
}
