using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aid : MonoBehaviour
{
    public int bonusHealth;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Health health = col.gameObject.GetComponent<Health>();
            health.SetHealth(bonusHealth);

            Destroy(gameObject);
        }
    }
}
