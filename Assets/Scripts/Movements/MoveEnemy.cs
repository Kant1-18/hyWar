using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    public float speed = 1f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY - 1);

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
