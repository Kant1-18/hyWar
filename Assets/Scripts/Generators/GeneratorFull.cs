using UnityEngine;
using System.Collections;

public class GeneratorFull : MonoBehaviour
{
    private Spawner spawner;

    private void OnMouseDown()
    {
        GlobalVariables.Coins += 50;
        spawner.GeneratorEmpty(transform.position);
        Destroy(gameObject);
    }
}
