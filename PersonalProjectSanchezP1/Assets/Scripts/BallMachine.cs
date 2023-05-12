using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMachine : MonoBehaviour
{
    public List<GameObject> targets;
    public bool isGameActive;
    private float spawnRate = 2.0f;
    private Rigidbody ballRb;
    private float minSpeed = 2;
    private float maxSpeed = 2;
    private float maxTorque = 10;
    private float xRange = 4;
    private float ySpawnPos = -6;
    // Start is called before the first frame update
    void Start()
    {
        ballRb = GetComponent<Rigidbody>();
        ballRb.AddForce(RandomForce(), ForceMode.Impulse);
        ballRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);
        transform.position = RandomSpawnPos();
    }
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }
    float RandomTorque()
    {
        return Random.Range(-maxTorque, maxTorque);
    }
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
    IEnumerator SpawnTarget()
    {
        while (isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Count);
            Instantiate(targets[index]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
