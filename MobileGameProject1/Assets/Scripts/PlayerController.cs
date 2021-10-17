using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public bool cooldown;
    
    public Text directionText; //Touch Controls
    private Touch theTouch;
    private Vector2 touchStartPosition, touchEndPosition;
    private string direction;
    private float coolDownSpeed = .2f;
    


    // This script controlls the player. 
    // 1:Sets Players position to the middle lane 2:Runs the coroutine "ShapePicker", which choses the shape the player turns into 1 of the three shapes. Cube, Donut, and cone
    // 3:Checks for the players input
    

    // Start is called before the first frame update
    void Start()
    {
        //Sets players position to the middle lane and sets its initial shape
        player.transform.position = posMid.transform.position;
        StartCoroutine("ShapePicker");
        cooldown = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        //TOUCH CONTROLS
           if (Input.touchCount > 0)
        {
            theTouch = Input.GetTouch(0);

            if (theTouch.phase == TouchPhase.Began)
            {
                touchStartPosition = theTouch.position; 
            }else if (theTouch.phase == TouchPhase.Moved || theTouch.phase == TouchPhase.Ended)
            {
                touchEndPosition = theTouch.position;

                float x = touchEndPosition.x - touchStartPosition.x;
                float y = touchEndPosition.y - touchEndPosition.x;

                if (Mathf.Abs(x) == 0 && Mathf.Abs(y) == 0)
                {
                    direction = "Tapped";
                }else if (Mathf.Abs(x) > Mathf.Abs(y))
                {
                    //conditional operator expression
                    direction = x > 0 ? "Right" : "Left";   //if this boolean is true it will preform "right" otherwise "Left"
                }
                else
                {
                    direction = y > 0 ? "Up" : "Down";
                }
            }
        }

        directionText.text = direction;
        // Touch Controls :https://learn.unity.com/tutorial/touch-input-for-mobile-scripting-2019#5dfba291edbc2a1a9859b892

        //Get player input and player movement on the lanes
        //If player swiped left/right moves the player to the correct lane.
        
        if(Input.GetKeyDown(KeyCode.A) || (direction == "Left")  && (cooldown == false)){
            if((player.transform.position == posMid.transform.position))
            {
                player.transform.position = posLeft.transform.position;
                 cooldown = true;
                 Invoke("CoolDownChecker", coolDownSpeed);
            }
            else if ((player.transform.position == posRight.transform.position)){
                 player.transform.position = posMid.transform.position;
                 cooldown = true;
                 Invoke("CoolDownChecker", coolDownSpeed);
                 
                
            }
            Invoke("CoolDownChecker", coolDownSpeed);
        }
        if(Input.GetKeyDown(KeyCode.D) || (direction == "Right") && (cooldown == false)){
            if((player.transform.position == posMid.transform.position)){
                player.transform.position = posRight.transform.position;
                cooldown = true;
                 Invoke("CoolDownChecker", coolDownSpeed);
                
                
            }
            else if ((player.transform.position == posLeft.transform.position)){
                  player.transform.position = posMid.transform.position;
                  cooldown = true;
                  Invoke("CoolDownChecker", coolDownSpeed);
                  
            }
        }
    }

    private void CoolDownChecker()
    {
        cooldown = false;
        direction = ""; //Sets direction to basically a empty string to clear it so it doesnt stay the same.
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
