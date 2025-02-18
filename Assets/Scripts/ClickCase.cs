using UnityEngine;


public class ClickCase : MonoBehaviour
{
    private Spawner spawner = new Spawner();

    private void OnMouseDown()
    { 
        spawner.Friend();
        gameObject.SetActive(false);
    }
}
