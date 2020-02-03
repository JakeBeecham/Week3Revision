using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject ObjectToSpawn;
    Vector3 mousePosition;

	void Update ()
    {
        //if the left mouse button was pressed
        //0 = left
        //1 = right
        //2 = middle
        if (Input.GetMouseButtonDown(0))
        {
            //mouse is in screen space, transform into world space
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //don't need the Z axis, set it zero
            mousePosition.z = 0;

            Instantiate(ObjectToSpawn, mousePosition, Quaternion.identity);
        }
	}
}
