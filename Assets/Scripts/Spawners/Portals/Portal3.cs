using UnityEngine;
using System.Collections;

public class Portal3 : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    public void Spawn()
    {
        spawner.Enemy(transform.position);
    }
}
