using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectivePosition : ScriptableObject {
    public ObjectivePosition(Objective objective, Vector2 position)
    {
        this.objective = objective;
        this.position = position;
    }
    public Objective objective;
    public Vector2 position;
}
