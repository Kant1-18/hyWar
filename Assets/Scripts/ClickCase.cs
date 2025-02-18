using UnityEngine;


public class ClickCase : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    private void OnMouseDown()
    {
        //if (!GlobalVariables.isFirstObjectSpawned)
        //{
        //    GlobalVariables.isFirstObjectSpawned = true;
        //    spawner.ActiveRandomPortals();
        //}

        GameObject spawnedFriend = spawner.Friend(transform.position);
        if (spawnedFriend != null)
        {
            gameObject.SetActive(false);
        }
    }
}
