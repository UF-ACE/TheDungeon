using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnvironmentObjects : Entity {

    public EnvironmentObjects(string name, float health, float maxHealth) : base(name, health, maxHealth, 0)
    { }

}
