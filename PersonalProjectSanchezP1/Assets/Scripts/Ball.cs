using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Rigidbody ballRb;
    public float speed = 1;
    public float xSpawnPos;
    public float ySpawnPos;
    public float zSpawnPos;
    public float xThrustRange;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //calling rigidbody components
        ballRb = GetComponent<Rigidbody>();
        //adding force to ball
        ballRb.AddForce(Random.Range(xThrustRange, -xThrustRange), Random.Range(8,0), -60, ForceMode.Impulse);
        //adding torque to ball
        ballRb.AddTorque(Torque(), 0, 0, ForceMode.Impulse); ;
        //transforming on position
        transform.position = SpawnPos();
        //Finding GameManager to use in Ball script
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    
    float Torque()
    {
        //Fuction to add random Torque
        return Random.Range(500, 1000);
    }
    Vector3 SpawnPos()
    {
        //Function setting spawn position
        return new Vector3(xSpawnPos, ySpawnPos, zSpawnPos);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
