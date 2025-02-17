using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX - 1, moveY);

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
