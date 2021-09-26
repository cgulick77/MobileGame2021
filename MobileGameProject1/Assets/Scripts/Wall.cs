using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject wall;
    private float   speed = 30f;
     Rigidbody wRb;

    public bool activated;
    // Start is called before the first frame update
    void Start()
    {
        wRb = GetComponent<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (activated == true){
            transform.Translate(Vector3.back * Time.deltaTime * speed);
            //Debug.Log("Hello");

           
        }
            
        
    }
}
