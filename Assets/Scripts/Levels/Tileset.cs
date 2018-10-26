using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tileset : ScriptableObject
{
    public string name;
    public GameObject[] roomPool;
    public GameObject[] enemyPool;
    public GameObject[] dynamicDecorationPool;
    public GameObject[] staticDecorationPool;
    public GameObject[] clutterPool;
}
