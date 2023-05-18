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
        //at the start of this script no matter what start game will be called
        StartGame();
    }
    public void StartGame()
    {
        //the ball will spawn every 2 seconds, repeated every 1
        InvokeRepeating("SpawnBall", 2, 1);

    }
    void SpawnBall()
    {   
        //every time the function Spawn Ball will be called 
        //in this case in Invoke Repeating a ball will be instantiated
         Instantiate(ball);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
