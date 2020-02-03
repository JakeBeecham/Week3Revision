using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardMovement : MonoBehaviour
{
    public float movementSpeed = 10;

    //variables to store input from user
    public float horizontal, vertical;

    //physics
    Rigidbody2D body;

    //speed at which to rotate the object
    public float rotationSpeed = 10;

	void Start ()
    {
        //get a component of type Rigidbody2D from the current game object
        body = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        //get the input for the W,A,S,D and the arrow keys
        vertical = Input.GetAxis("Vertical");
        horizontal = Input.GetAxis("Horizontal");

        //if the Q key is pressed
        if(Input.GetKey(KeyCode.Q))
        {
            //rotate left
            //rotation stored in the transfrom
            transform.Rotate(0, 0, rotationSpeed);
        }
        else if(Input.GetKey(KeyCode.E))//else if the E key is pressed
        {
            //rotate right
            //rotation stored in the transfrom
            transform.Rotate(0, 0, -rotationSpeed);
        }
	}

    //FixedUpdate results in smoother movement
    void FixedUpdate()
    {
        //value between -1 and 1
        //deltatime gives a percentage of how to move based on the frame rate
        body.velocity = new Vector2(horizontal, vertical) * movementSpeed * Time.deltaTime;//0.16
    }
}
