using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Level: Describes a level
public class Level : MonoBehaviour
{
    public enum Mission { Capture, Assassinate, Steal }
    public enum LevelSize { Small, Medium, Large }

    public Tileset tileset;
    public Mission missionType;
    public LevelSize size;

    int enteranceCount;

    // Awards
    int notorityAward, creditAward;
}
