using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject wall;
    public float   speed = 70f;
     Rigidbody wRb;

    public bool activated;
    public Collider [] shapes;
    // Start is called before the first frame update
    void Start()
    {
        wRb = GetComponent<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        if (activated == true){
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            //Debug.Log("Hello");

           
        }
            
        
    }
}
