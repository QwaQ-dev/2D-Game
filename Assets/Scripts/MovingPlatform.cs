using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public GameObject leftBorder;
    public GameObject rightBorder;
    public Rigidbody2D rb;

    public bool isRightDirection;
    public SpriteRenderer spriteRenderer;

    public float speed;
    private void Update()
    {
        if (isRightDirection)
        {
            spriteRenderer.flipX = true;
            rb.velocity = Vector2.right * speed;
            if (transform.position.x > rightBorder.transform.position.x)
                isRightDirection = !isRightDirection;
        }
        else
        {
            spriteRenderer.flipX = false;
            rb.velocity = Vector2.left * speed;
            if (transform.position.x < leftBorder.transform.position.x)
                isRightDirection = !isRightDirection;
        }
    }
}
