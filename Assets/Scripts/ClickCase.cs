using UnityEngine;

public class ClickCase : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    private void OnMouseDown()
    {
        GameObject spawnedFriend = spawner.Friend(transform.position);

        
        if (spawnedFriend != null)
        {
            gameObject.SetActive(false);
        }
    }
}
