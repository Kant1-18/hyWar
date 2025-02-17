using UnityEngine;
using System.Collections;

public class MoveProjectile : MonoBehaviour
{
    public float speed = 5f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveX, moveY - 1);

        transform.Translate(movement * Time.deltaTime * speed);
    }
}
