using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_new : MonoBehaviour {

	private Rigidbody2D rb2d;
	public float speed;
	public float JumpPower;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();

	}

	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		movement (horizontal ,vertical);
	}

	void movement (float horizontal, float vertical){
		rb2d.velocity = new Vector2 (horizontal * speed, vertical * JumpPower);
	}

}
