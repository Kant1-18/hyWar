using UnityEngine;
using System.Collections;

public class GeneratorFull : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    private void OnMouseDown()
    {
        GlobalVariables.Coins += 150;
        spawner.GeneratorEmpty(transform.position);
        Destroy(gameObject);
    }
}
