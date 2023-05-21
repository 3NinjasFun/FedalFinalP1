using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketCollision : MonoBehaviour
{
    private float thrust = 80.0f;
    public Rigidbody Ballrb;
    public float Score;
    public int ScoreToAdd;
    private GameManager gameManager;
    float ballXRange = 15;
    
    
    void Start ()
    {
        Ballrb = GetComponent<Rigidbody>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();


    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        { 

            Ballrb.velocity = Vector3.zero;
            Ballrb.AddForce(Random.Range(ballXRange, -ballXRange) ,Random.Range(0, -10) , thrust, ForceMode.Impulse);
            

            gameManager.UpdateScore(1);
        }
        if (collision.gameObject.name == "GameBound")
        {
            gameManager.GameOver();
        }
    }
}
