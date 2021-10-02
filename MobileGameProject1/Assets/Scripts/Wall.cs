using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject wall;
    public float   speed = 70f;
     Rigidbody wRb;

    public bool activated;
    public bool shapeActivated;
    public Collider [] shapes;
    public Collider Cone1;
    public Collider Cube1;
    public Collider Donut1;
    // Start is called before the first frame update
    void Start()
    {
        wRb = GetComponent<Rigidbody>();
         
    }

    // Update is called once per frame
    void Update()
    {
        //Picks which shape hole 
        int randomShape = Random.Range(0, shapes.Length);
        // Activate the chosen shape hole and leave the other off
        

        if (activated == true){
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            //Debug.Log("Hello");
        }
            
        
    }

     private void OnCollisionEnter(Collision other) {
        
    }
}
