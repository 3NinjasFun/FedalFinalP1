using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketCollision : MonoBehaviour
{
    public Rigidbody Ballrb;
    public float thrust = 80.0f;
    public float force = 100.0f;
    private GameManager gameManager;

    private void Start()
    {
        Ballrb = GetComponent<Rigidbody>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Player")
        {
            Ballrb.AddForce(transform.forward * 500, ForceMode.Impulse);  
            //Ballrb.AddForce(0, 0, force, ForceMode.Impulse);
            gameManager.UpdateScore(1);
        }

        if (collisionInfo.gameObject.name == "GameBound")
        {
            gameManager.GameOver();
        }
    }
}
