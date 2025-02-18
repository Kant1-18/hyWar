using UnityEngine;
using System.Collections;

public class Portal1 : MonoBehaviour
{
    private Spawner spawner;

    public void Spawn()
    {
        spawner.Enemy(transform.position);
    }
}
