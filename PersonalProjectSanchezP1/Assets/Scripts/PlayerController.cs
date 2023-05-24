using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //number value that controls the speed the player moves 
    public float speed;
    float horizontalInput;
    float verticalInput;

    //number values that are used to bound the players vertical and horizontal movement
    public float verticalBound;
    public float horizontalBound;
    public float rotationBound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
        //calling both move and limit player
        LimitPlayer();
    }
    private void MovePlayer () 
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
   
        //when the "Vertical" key is pressed the player moves up or down
        transform.Translate(Vector3.up * speed * Time.deltaTime * verticalInput);
        //when "Horizontal" key is inputed the player moves left or right
        transform.Translate(Vector3.right * speed * Time.deltaTime * horizontalInput);
    }
    //this script limits both vertical and horizontal movement
    private void LimitPlayer ()
    {
        if (transform.position.y > verticalBound)
        {
            transform.position = new Vector3(transform.position.x, verticalBound, transform.position.z);
        }
        if (transform.position.y < -verticalBound)
        {
            transform.position = new Vector3(transform.position.x, -verticalBound, transform.position.z);
        }

        if (transform.position.x > horizontalBound)
        {
            transform.position = new Vector3(horizontalBound, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -horizontalBound)
        {
            transform.position = new Vector3(-horizontalBound, transform.position.y, transform.position.z);
        }
    }
}
