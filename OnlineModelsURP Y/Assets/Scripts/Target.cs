﻿using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 100f;
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
