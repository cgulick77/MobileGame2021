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

    public GameObject [] playerShapes;



    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = posMid.transform.position;
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
}
