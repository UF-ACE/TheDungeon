using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

    private readonly string entityName;
    private float health;
    private readonly float maxHealth;
    private float moveSpeed;

    public Entity(string name, float health, float maxHealth, float moveSpeed)
    {
        this.entityName = name;
        this.health = health;
        this.maxHealth = maxHealth;
        this.moveSpeed = moveSpeed;
    }

    public string GetName()
    {
        return entityName;
    }

    public float GetHealth()
    {
        return health;
    }

    public float GetMaxHealth()
    {
        return maxHealth;
    }

    protected void Die()
    {
        Destroy(gameObject);
    }

    public void Damage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
    }
}
