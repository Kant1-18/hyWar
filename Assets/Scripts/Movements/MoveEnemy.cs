using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY - 1);

        transform.Translate(movement * Time.deltaTime * GlobalVariables.EnemiesSpeed);
    }
}
