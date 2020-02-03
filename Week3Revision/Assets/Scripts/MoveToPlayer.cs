using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    GameObject player;
    public float movementSpeed = 100;
    Rigidbody2D body;

	void Start ()
    {
        body = GetComponent<Rigidbody2D>();
        //will find the game object with the tag of Player
        player = GameObject.FindGameObjectWithTag("Player");

        Vector3 direction = player.transform.position - transform.position;
        direction.z = 0;
        direction.Normalize();

        body.velocity = direction * movementSpeed;
	}
}
