using UnityEngine;


public class ClickCase : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    private void OnMouseDown()
    {
        if (!GlobalVariables.isFirstObjectSpawned)
        {
            GlobalVariables.isFirstObjectSpawned = true;
            spawner.ActiveRandomPortals();
        }

        spawner.Friend(transform.position);
        gameObject.SetActive(false);
    }
}
