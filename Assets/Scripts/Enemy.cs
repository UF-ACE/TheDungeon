using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Entity
{


    public Enemy(string name, float health, float maxHealth) : base(name, health, maxHealth)
    { }

    public abstract void AI();




}
