using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketCollision : MonoBehaviour
{
    public Rigidbody Ballrb;
    public float thrust = 80.0f;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Ball")
        {
            Ballrb = GetComponent<Rigidbody>();
            Ballrb.AddForce(0, 0, thrust, ForceMode.Impulse);
        }
    }
}
