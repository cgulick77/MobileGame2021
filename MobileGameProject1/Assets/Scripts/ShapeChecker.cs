using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Checks if the player misses the correct hole.
public class ShapeChecker : MonoBehaviour
{
    //The goal of this scipt is to detect if the player hits the barrier. 
    //The barrier determines if the player hits the wrong hole.
    
    public Collider wallChecker;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Wrong");
        
    }
}
