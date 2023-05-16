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
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody>();
        ballRb.AddForce(Force(), ForceMode.Impulse);
        ballRb.AddTorque(Torque(), 0, 0, ForceMode.Impulse); ;
        transform.position = SpawnPos();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    Vector3 Force()
    {
        return Vector3.back * speed;
    }
    float Torque()
    {
        return Random.Range(500, 1000);
    }
    Vector3 SpawnPos()
    {
        return new Vector3(xSpawnPos, ySpawnPos, zSpawnPos);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
