using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public GameObject posLeft;
    public GameObject posRight;
    public GameObject posMid;
    private bool leftPos;
    private bool rightPos;
    private bool midPos;
    private int row;
    public GameObject Cone;
    public GameObject Cube;
    public GameObject Donut;
    public int playerShape;
    


    // This script controlls the player. 
    // 1:Sets Players position to the middle lane 2:Runs the coroutine "ShapePicker", which choses the shape the player turns into 1 of the three shapes. Cube, Donut, and cone
    // 3:Checks for the players input
    

    // Start is called before the first frame update
    void Start()
    {
        //Sets players position to the middle lane and sets its initial shape
        player.transform.position = posMid.transform.position;
        StartCoroutine("ShapePicker");
        
    }

    // Update is called once per frame
    void Update()
    {
        //Get player input and player movement on the lanes
        if(Input.GetKeyDown(KeyCode.A)){
            if(player.transform.position == posMid.transform.position){
                player.transform.position = posLeft.transform.position;

            }
            else if (player.transform.position == posRight.transform.position){
                player.transform.position = posMid.transform.position;

            }
        }
        if(Input.GetKeyDown(KeyCode.D)){
            if(player.transform.position == posMid.transform.position){
                player.transform.position = posRight.transform.position;

            }
            else if (player.transform.position == posLeft.transform.position){
                player.transform.position = posMid.transform.position;

            }
        }
    
    }
     IEnumerator ShapePicker()
        {
             // Uses Random.Range to pick the shape. Thne uses a switch statement to activate the shape and keep the other deactivated.
        playerShape = Random.Range(1,4);

        switch (playerShape)
        {
            case 1:
                Cone.SetActive(true);
                Cube.SetActive(false);
                Donut.SetActive(false);
                break;
            case 2:
                Cone.SetActive(false);
                Cube.SetActive(true);
                Donut.SetActive(false);
                break;
            case 3:
                Cone.SetActive(false);
                Cube.SetActive(false);
                Donut.SetActive(true);
                break;
                
        }
        yield return null;
        }
}
