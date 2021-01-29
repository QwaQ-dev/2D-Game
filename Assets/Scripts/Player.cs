using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed;


    public static Player instance;

    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    private Vector3 direction;
    public GroundDetection groundDetection;
    public bool cheatMode;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (instance == null)
            instance = this;
    }

    
    void FixedUpdate()
    {
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.A))
            direction = Vector3.left; // (-1, 0)
        if (Input.GetKey(KeyCode.D))
            direction = Vector3.right; // (1, 0)

        direction *= speed;
        direction.y = rb.velocity.y;
        rb.velocity = direction;



        if (direction.x > 0)
        {
            spriteRenderer.flipX = false;
        }
        if (direction.x < 0)
        {
            spriteRenderer.flipX = true;
        }

        DeadZone();
    }
    private void DeadZone()
    {
        if (transform.position.y < -10 && !cheatMode)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < -10 && cheatMode)
        {
            transform.position = new Vector2(0, -3);
        }
    }
}
