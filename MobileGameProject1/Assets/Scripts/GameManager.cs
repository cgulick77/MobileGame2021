using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public int score;
    public int lives = 5;
    
    // Start is called before the first frame update

     void Awake() 
     {
        
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
        Debug.Log(lives);

        
    }

    public void ScoreUpdate()
    {
        score = score + 100;
    }

    public void LiveUpdate()
    {
        lives = lives--;
    }
}
