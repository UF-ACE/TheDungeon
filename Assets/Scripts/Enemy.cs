using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Entity
{


    public Enemy(string name, float health, float maxHealth, float moveSpeed) : base(name, health, maxHealth, moveSpeed)
    { }

    public abstract void AI();




}
