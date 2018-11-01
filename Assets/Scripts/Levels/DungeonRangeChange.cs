using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DungeonRangeChange : MonoBehaviour {

    public GameObject DungeonRange;
    public int rangeSize = 30;
	void Start () {
        DungeonRange.transform.localScale = new Vector2(rangeSize*2, rangeSize*2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
