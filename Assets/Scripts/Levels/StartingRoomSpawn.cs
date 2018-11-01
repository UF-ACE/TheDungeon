using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartingRoomSpawn : MonoBehaviour
{
    public int DungeonRange = 30;
    public int spawnRadius = 5;
    public GameObject playerRoom;
    public GameObject endRoom;

    void Start()
    {
        SpawnStartRooms();
    }

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void SpawnStartRooms()
    {
        playerRoom.transform.position = new Vector3(Random.Range(-DungeonRange, DungeonRange), Random.Range(-DungeonRange, DungeonRange), 0);

        //Check if endRoom position is in the spawnRadius of playerRoom
        do
        {
            endRoom.transform.position = new Vector3(Random.Range(-DungeonRange, DungeonRange), Random.Range(-DungeonRange, DungeonRange), 0);
        }

        while (Vector3.Distance(playerRoom.transform.position, endRoom.transform.position) < spawnRadius * 2);

        print("Distance " + Vector3.Distance(playerRoom.transform.position, endRoom.transform.position));
    }
}
