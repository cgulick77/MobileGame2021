using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Checks if the player misses the correct hole.
public class ShapeChecker : MonoBehaviour
{
    //The goal of this scipt is to detect if the player hits the barrier. 
    //The barrier determines if the player hits the wrong hole.
    
    public Collider wallChecker;
    public bool wrong;
    private GameManager gameManager;
    
    // Start is called before the first frame update
    void Start()
    {
        //gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("Wrong");
        wrong = true;
        //gameManager.LiveUpdate();
        
    }
}
