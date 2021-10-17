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
    public TextMeshProUGUI streakText;
    public float   speed = 0.0f;
    


    
    // Start is called before the first frame update

     void Awake() 
     {
        NormalButton();
        MainMenu();
    }
    void Start()
    {
        
        
    }

    // Update is called once per frame
    public void Update()
    {
        //Debug.Log(score);
        //Debug.Log(lives);

        
    }

    //Difficulty 
    public void EasyButton()
    {
        speed = 60.0f;
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        Time.timeScale = 1;
    }
    public void NormalButton()
    {
        speed = 80.0f;
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        Time.timeScale = 1;
    }
    public void HardButton()
    {
        speed = 90.0f;
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        Time.timeScale = 1;
    }

    //Menu Functions
    public void PauseMenu()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(true);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }
    public void MainMenu()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(true);
    }
    public void SettingsMenu()
    {
        Time.timeScale = 0;
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(true);
        mainMenu.gameObject.SetActive(false);
    }

    //Button Functions
    public void PlayButton()
    {
        Time.timeScale = 1;
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
    }
    public void NewGame()
    {
        SceneManager.LoadScene( SceneManager.GetActiveScene().name );
        miniMenu.gameObject.SetActive(false);
        settingsMenu.gameObject.SetActive(false);
        mainMenu.gameObject.SetActive(false);
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

    private void ScoreChecker()
    {
        if (score < 0)
        {
            score = 0;
            streakText.text = "Score: " + score;
        }
    }
}
