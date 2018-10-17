using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour {

	public float speed;

    private Rigidbody2D rb2d;
	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}

	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis ("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce (movement * speed);
	// if(Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
	// 	{
	// 		Debug.Log("Left Pessed");
	// 		transform.Translate(Vector2.left * movmentMult * Time.deltaTime);
	// 	}
	// 	//if moving right

	// 	if(Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
	// 	{
	// 		Debug.Log("Left Pessed");
	// 		transform.Translate(Vector2.right * movmentMult * Time.deltaTime);
	// 	}
	// 	if(Input.GetKey(KeyCode.UpArrow)||Input.GetKey(KeyCode.W))
	// 	{
	// 		Debug.Log("Left Pessed");
	// 		transform.Translate(Vector2.up * movmentMult * Time.deltaTime);
	// 	}
	// 	//if moving right

	// 	if(Input.GetKey(KeyCode.DownArrow)||Input.GetKey(KeyCode.S))
	// 	{
	// 		Debug.Log("Left Pessed");
	// 		transform.Translate(Vector2.down * movmentMult * Time.deltaTime);
	// 	}
	}
}
