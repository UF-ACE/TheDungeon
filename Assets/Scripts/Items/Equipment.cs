using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : Item {

	public enum Slot { Hat, Face, Shirt, Arm, ArmNoWeapon, Module, Leg, Pants, Boots };

    public Slot equipmentSlot;
    public float armorValue;
}
