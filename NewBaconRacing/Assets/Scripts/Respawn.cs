using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class Respawn : MonoBehaviour
{
 
    public int numPlayer;
    public GameObject[] player;


    public int numSpawn;
    public GameObject[] spawnLocations;

    public void Start()
    {
        spawnLocations = GameObject.FindGameObjectsWithTag("spawn");
        numSpawn = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        Spawn(numPlayer,numSpawn);

        if (numSpawn == 0)
        {
            numSpawn += 1;
        }
        else if (numSpawn > 1)
        {
            numSpawn = 0;
        }

    }

    public void Spawn(int numPlayer,int numSpawn)
    {
       

        player[numPlayer].transform.position = new Vector3(spawnLocations[numSpawn].transform.position.x, spawnLocations[numSpawn].transform.position.y, spawnLocations[numSpawn].transform.position.z);
        player[numPlayer].transform.eulerAngles = new Vector3(spawnLocations[numSpawn].transform.eulerAngles.x, spawnLocations[numSpawn].transform.eulerAngles.y, spawnLocations[numSpawn].transform.eulerAngles.z);

    }

   
    
}
