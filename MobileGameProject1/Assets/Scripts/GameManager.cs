using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public int score;
    public GameObject mainMenu;
    public GameObject settingsMenu;
    public GameObject miniMenu;

    public GameObject gameOver;
    public GameObject win;
    public TextMeshProUGUI streakText;
    public TextMeshProUGUI challengeText;
    public float   speed = 0.0f;
    private SoundManager soundManagerScript;
    public int challenge;

    


    
    // Start is called before the first frame update

     void Awake() 
     {
        
    }
    void Start()
    { 
        score = 0;
        challenge = 1;
        MainMenu();
        speed = 80.0f;
         soundManagerScript = FindObjectOfType<SoundManager>();
         //soundManagerScript.PlaySound("bgm");
    }

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(score);
        //Debug.Log(lives);
        if (score == challenge)
        {
            WinMenu();
        }
        if (score == -1)
        {
            GameOverMenu();
        }
        if(score < -1)
        {
            score = 0;
        }
        
    }

    //Difficulty 
    public void EasyButton()
    {
        speed = 60.0f;
        MainMenu();
        Time.timeScale = 0;
    }
    public void NormalButton()
    {
        speed = 80.0f;
        MainMenu();
        Time.timeScale = 0;
    }
    public void HardButton()
    {
        speed = 90.0f;
        MainMenu();
        Time.timeScale = 0;
    }

    //Menu Functions

    public void WinMenu()
    {
        Time.timeScale = 0;
         win.gameObject.SetActive(true);
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }

    public void GameOverMenu()
    {
        Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
            miniMenu.gameObject.SetActive(false);
            settingsMenu.gameObject.SetActive(false);
            mainMenu.gameObject.SetActive(false);
    }
    public void PauseMenu()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
    }
    public void MainMenu()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
        win.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
    }
    public void SettingsMenu()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
    }

    //Button Functions
    public void PlayButton()
    {
        Time.timeScale = 1;
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        ChallengeRng();
    }
    public void NewGame()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        gameOver.gameObject.SetActive(false);
        ChallengeRng();
        Time.timeScale = 1;
    }

    //Score Functions
    public void ScoreUpdate()
    {
        score = score + 1;
        streakText.text = "Score: " + score;
    }

    public void LiveUpdate()
    {
        score = score - 1;
        streakText.text = "Score: " + score;
    }

    public void ChallengeRng()
    {
        challenge = Random.Range(5, 20);
        challengeText.text = "Challenge: " + challenge;

    }

    
}
