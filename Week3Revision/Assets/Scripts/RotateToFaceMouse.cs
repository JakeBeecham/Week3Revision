using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateToFaceMouse : MonoBehaviour
{
    Vector3 mousePosition;
    Vector3 direction;

    void Update ()
    {
        //get the mouse position position
        //mouse is in screen space, transform into world space
        //unprojection
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //don't need the Z axis, set it zero
        mousePosition.z = 0;

        //get the direction (angle) between us and the mouse
        //subtract their position
        direction = mousePosition - transform.position;

        //set our forward direction to be that angle
        transform.up = direction;
	}
}
