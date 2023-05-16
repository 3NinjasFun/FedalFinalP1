using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private float spawnRate = 2.0f;
    public GameObject ball;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    public void StartGame()
    {
        InvokeRepeating("SpawnBall", 2, 1);
    }
    void SpawnBall()
    {   
         Instantiate(ball);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
