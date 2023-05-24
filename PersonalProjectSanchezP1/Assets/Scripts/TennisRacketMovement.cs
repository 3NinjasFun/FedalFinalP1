using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisRacketMovement : MonoBehaviour
{
    public Vector3 rotation;
    Vector3 pos;
    public float speed = 12;
    public float rotationBound = 15;
    //Tennis Racket becomes mouse cursor
    void Update ()
    {
        pos = Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
        
        

        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(rotation * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-rotation * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
             transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        else if(Input.GetKey(KeyCode.W))
        {
             transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        
    }

}
