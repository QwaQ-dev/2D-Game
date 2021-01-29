using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platfrom : MonoBehaviour
{
    public float force = 10f;
    public GroundDetection groundDetection;
    public Rigidbody2D rb;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.relativeVelocity.y < 0)
            Player.instance.rb.velocity = Vector2.up * force;
    }
}
