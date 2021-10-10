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
    private ShapeChecker shapeCheckerScript;
    public GameObject checker;

    void Awake() {
        playerControllerScript = playerController.GetComponent<PlayerController>();
        shapeCheckerScript = checker.GetComponent<ShapeChecker>();
    }
    // Start is called before the first frame update
    void Start()
    {
        wRb = GetComponent<Rigidbody>();
        //activated = true;

         
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

    // Detects when the player collides with the correct hole for its shape
      private void OnCollisionEnter(Collision collision) {
          if (collision.gameObject.layer == 8)
          {
              checker.SetActive(false);
              Debug.Log("Correct");
          }
         
         
      }

      //Add an OnCollisionExit
}
