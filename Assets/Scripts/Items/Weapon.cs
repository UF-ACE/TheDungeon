using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Item
{
    public enum Handed { One, Two };
    public enum ShotType { Continuous, Bullet };
    public enum ShotLength {  Semi, Burst, Auto };

    public int fireRate;

    public Handed handedness;
    public ShotType shotType;

    public int burstAmount;
    public ShotLength shotLength;

    public float damagePerSecond;
    
}
