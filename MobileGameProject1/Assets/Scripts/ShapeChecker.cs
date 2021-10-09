using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Checks if the player misses the correct hole.
public class ShapeChecker : MonoBehaviour
{
    
    public Collider wallChecker;
    public bool collided;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        collided = true;
        Debug.Log("Wrong");
    }
}
