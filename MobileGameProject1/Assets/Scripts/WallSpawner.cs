using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject [] walls;
    public GameObject spawnPos;
    public bool maxWalls = false;
    public bool activated;
    private Wall wallscript;
    public int wallLimit = 0;

    // Start is called before the first frame update
    void Start()
    {
        wallscript = GetComponent<Wall>();
    }

    // Update is called once per frame
    void Update()
    {
        //Picks a random wall from the list
        int randomWall = Random.Range(0, walls.Length);
        //When "activated" is true it starts the script.
        //Make couroutine
        if ((activated == true) && (maxWalls == false)){
            Instantiate(walls[randomWall], spawnPos.transform.position, spawnPos.transform.rotation);
            wallLimit++;
            
        }
        
        switch (wallLimit)
        {
            case 10:
           maxWalls = true;
            break;
        }
    }

    

    void WallRng(){
        
    }
}
