using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.y > 15)
        {
            transform.rotation = Quaternion.Euler(0, 15, -90);
        }
        if (transform.rotation.y < -15)
        {
            transform.rotation = Quaternion.Euler(0, -15, -90);
        }
    }
}
