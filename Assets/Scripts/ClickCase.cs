using UnityEngine;


public class ClickCase : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    private void OnMouseDown()
    { 
        spawner.Friend(transform.position);
        gameObject.SetActive(false);
    }
}
