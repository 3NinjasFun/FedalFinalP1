using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisRacketMovement : MonoBehaviour
{

    Vector3 pos;
    public float speed =  1f;
    //Tennis Racket becomes mouse cursor
    void Update ()
    {
        pos = Input.mousePosition;
        pos.z = speed;
        transform.position = Camera.main.ScreenToWorldPoint(pos);
    }
}
