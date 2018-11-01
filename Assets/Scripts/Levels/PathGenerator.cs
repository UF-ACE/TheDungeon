using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathGenerator : MonoBehaviour {

    public GameObject roomOne;
    public GameObject roomTwo;

    public GameObject PathTile;
    public GameObject Path;
    float Rise;
    float Run;

    GameObject EndPath;

    void Start () {
        if(roomOne.transform.position.y > roomTwo.transform.position.y)
            Rise = (roomTwo.transform.position.y - roomOne.transform.position.y) - 1;
        if (roomOne.transform.position.y < roomTwo.transform.position.y)
            Rise = (roomTwo.transform.position.y - roomOne.transform.position.y) + 1;

        Run = roomTwo.transform.position.x - roomOne.transform.position.x;

        print("Rise: " + Rise);
        print("Run: " + Run);

        CreatePath(Rise, Run);
    }

    void CreatePath(float Rise, float Run)
    {
        Path = Instantiate(Path, new Vector3(0, 0, 0), Quaternion.identity);
        EndPath = roomOne;

        print("Path Create");
        print("Begin Rise");
        for (int i = 1; i < Mathf.Abs(Rise); i++)
        {
            int diff = i;
            if (Rise < 0)
                diff *= -1;
            EndPath = Instantiate(PathTile, new Vector3(roomOne.transform.position.x, roomOne.transform.position.y + diff, 0), Quaternion.identity, Path.transform);
        }
        print("Begin Run");
        for (int i = 1; i < Mathf.Abs(Run); i++)
        {
            int diff = i;
            if (Run < 0)
                diff *= -1;
            Instantiate(PathTile, new Vector3(EndPath.transform.position.x + diff, EndPath.transform.position.y, 0), Quaternion.identity, Path.transform);
        }
        print("Finish");
    }
}
