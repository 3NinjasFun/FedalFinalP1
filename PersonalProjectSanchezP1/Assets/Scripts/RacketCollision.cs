using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketCollision : MonoBehaviour
{
    public float thrust = 1.0f;
    public Rigidbody Racketrb;
    
    void Start ()
    {
        Racketrb = GetComponent<Rigidbody>();
        Racketrb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }
}
