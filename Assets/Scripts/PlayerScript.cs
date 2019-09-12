using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
	public float speed;             //Floating point variable to store the player's movement speed.

	// Use this for initialization
	void Start()
	{
	}

	//FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
	void Update()
	{
		float inputX = Input.GetAxis("Horizontal");
		float inputY = Input.GetAxis("Vertical");

		Vector2 basespeed = new Vector2(50, 50);
		Vector2 movement = new Vector2(
				basespeed.x * inputX,
				basespeed.y * inputY);

		GetComponent<Rigidbody2D>().velocity = movement;
		//Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
		
		//GetComponent<Rigidbody2D>().Move(transform.TransformDirection(input * speed * Time.deltaTime));
	}
}
