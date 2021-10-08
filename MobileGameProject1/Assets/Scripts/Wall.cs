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
    public Collider Cone1;
    public Collider Cube1;
    public Collider Donut1;
    private PlayerController playerControllerScript;
    public GameObject playerController;
    private int holeNum;

    public Collider Wall1;

    
    void Awake() {
        playerControllerScript = playerController.GetComponent<PlayerController>();
    }
    // Start is called before the first frame update
    void Start()
    {
        wRb = GetComponent<Rigidbody>();
        activated = true;

         
    }

    // Update is called once per frame
    // Enable all the 
    void Update()
    {
        if (activated == true){
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            //Debug.Log("Hello");
              
        }
        switch (playerControllerScript.playerShape)
        {
             case 1:
                Cone1.enabled = true;
                Cube1.enabled = false;
                Donut1.enabled = false;
                break;
            case 2:
                Cone1.enabled = false;
                Cube1.enabled = true;
                Donut1.enabled = false;
                break;
            case 3:
                Cone1.enabled = false;
                Cube1.enabled = false;
                Donut1.enabled = true;
                break;
        }

     

    }

      private void OnCollisionEnter(Collision collision) {
          if (collision.gameObject.CompareTag("Cone"))
          {
              Debug.Log("Cone");
          }
          if (collision.gameObject.CompareTag("Cube"))
          {
              Debug.Log("Cube");
          }
           if (collision.gameObject.CompareTag("Donut"))
          {
              Debug.Log("Donut");
          }
          else 
          {
              
          }
         
         
      }

      //Add an OnCollisionExit
}
