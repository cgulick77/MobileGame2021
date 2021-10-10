using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    // Spawns one of the four walls to spawn.
    public GameObject [] walls;
    public GameObject spawnPos;
    public bool maxWalls = false;
    public bool activated;
    private Wall wallscript;
    public int wallLimit = 0;

    public int startDelay = 2;
    public int repeatRate = 3;
   

    // Start is called before the first frame update
    void Start()
    {
        wallscript = GetComponent<Wall>();
        InvokeRepeating("WallRando", startDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
        //When "activated" is true it starts the script.
        
        // Creates walls, Everytime it makes wall it adds 1 to the wall Limit, if the wall limit == the max walls it stops
        if ((activated == true) && (maxWalls == false)){
            
            //activated = false;
        }
        
        switch (wallLimit)
        {
            case 5:
           maxWalls = true;
            break;
        }
        
        
    }
  

        void WallRando()
        {
            int randomWall = Random.Range(0, walls.Length);
            Instantiate(walls[randomWall], spawnPos.transform.position, spawnPos.transform.rotation);
        }

}
