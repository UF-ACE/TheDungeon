using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    private int fireRateBase = 30;
    private int shieldValue = 0;
    private float luck = 1;
    
    public Player() : base("Player", 100, 100, 50)
    { }


}
