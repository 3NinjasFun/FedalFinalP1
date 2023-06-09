using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketCollision : MonoBehaviour
{
    public GameObject gameObject;
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
        if(collisionInfo.collider.tag == "WilsonProStaff")
        {
            //Ballrb.AddForce(transform.forward * 500, ForceMode.Impulse);  
            
            gameManager.UpdateScore(1);
            
                
        }

        if (collisionInfo.gameObject.name == "GameBound")
        {
            gameManager.GameOver();
            GameObject[] allObjects = GameObject.FindGameObjectsWithTag("Ball");
            foreach (GameObject obj in allObjects)
            {
                Destroy(obj);
            }
                Destroy(gameObject);
        }

        
        
    }
    public void OnTriggerEnter(Collider trigger)
    {
        
    }
}
