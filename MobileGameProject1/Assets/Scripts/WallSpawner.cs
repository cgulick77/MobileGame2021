using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallSpawner : MonoBehaviour
{
    public GameObject [] walls;
    public GameObject spawnPos;
    public bool maxWalls = false;

    public bool activated;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randomWall = Random.Range(0, walls.Length);

        if ((activated == true) && (maxWalls == false)){
            Instantiate(walls[randomWall], spawnPos.transform.position, Quaternion.identity);
            maxWalls = true;
            

        }
        
    }

    

    void WallRng(){
        
    }
}
