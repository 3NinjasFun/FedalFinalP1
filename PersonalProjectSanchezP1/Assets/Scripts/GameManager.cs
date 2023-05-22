using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool isGameActive;

    public GameObject ball;
    private int score;

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreAfterText;
    public TextMeshProUGUI gameOverText;
    public Button restartButton;


    // Start is called before the first frame update
    void Start()
    {
        //at the start of this script no matter what start game will be called
        StartGame();
        isGameActive= true;
    }
    public void StartGame()
    {
        //the ball will spawn every 2 seconds, repeated every 1
        
        score = 0;
        UpdateScore(0);
        InvokeRepeating("SpawnBall", 2, 5);

        gameOverText.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        scoreText.gameObject.SetActive(true);
        scoreAfterText.gameObject.SetActive(false);

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
        scoreText.gameObject.SetActive(false);
        scoreAfterText.gameObject.SetActive(true);

        isGameActive = false;
        Time.timeScale= 0f;
    }

    public void Restart()
    {
        StartGame();
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
