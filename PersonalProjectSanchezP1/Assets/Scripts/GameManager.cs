using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;
using System.Threading;
using Unity.VisualScripting;
using System;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;

    public GameObject ball;
    private int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreAfterText;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI countdownText;
    public TextMeshProUGUI instructionText;
    public GameObject backGround;
    public Button restartButton;
    private float timeLeft;

    
    
    


    // Start is called before the first frame update
    void Start()
    {
        //at the start of this script no matter what start game will be called
        StartGame();
        
        
        
        isGameActive = true;
    }


    


    public void StartGame()
    {
        //the ball will spawn every 2 seconds, repeated every 1

        timeLeft = 7;

        score = 0;
        UpdateScore(0);
        InvokeRepeating("SpawnBall", 7, 5);

        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        backGround.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        scoreAfterText.gameObject.SetActive(false);
        countdownText.gameObject.SetActive(true);
        instructionText.gameObject.SetActive(true);

    }

    public void ReStartGame()
    {
        timeLeft = 3;
        score = 0;
        UpdateScore(0);
        

        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        backGround.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        scoreAfterText.gameObject.SetActive(false);
        countdownText.gameObject.SetActive(true);
    }
    void SpawnBall()
    {
        //every time the function Spawn Ball will be called 
        //in this case in Invoke Repeating a ball will be instantiated
       
            Instantiate(ball);
        
       
    }
    public void UpdateScore (int ScoreToAdd)
    {
        score += ScoreToAdd;
        scoreText.text = "Score: " + score;
        scoreAfterText.text = "Score: " + score;

    }

    public void GameOver()
    {
        gameOverText.gameObject.SetActive(true);       
        restartButton.gameObject.SetActive(true);
        backGround.gameObject.SetActive(true);
        scoreText.gameObject.SetActive(false);
        scoreAfterText.gameObject.SetActive(true);

        isGameActive = false;
        Time.timeScale= 0f;
    }

    public void Restart()
    {
        ReStartGame();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;
        TimeSpan timeSpanLeft = TimeSpan.FromSeconds(timeLeft);
        countdownText.text = timeSpanLeft.ToString(@"ss");
        if (timeLeft < 0)
        {
            countdownText.gameObject.SetActive(false);
            instructionText.gameObject.SetActive(false);
        }
    }
}
