﻿using UnityEngine;
using System.Collections;


public class player : MonoBehaviour {
	public float max_speed = 3;
    public float speed = 50;
    public float jump_power = 150f;
    public bool grounded;

    private Rigidbody2D rb2d; 
	private Animator anim;


	// Use this for initialization
	void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		anim = gameObject.gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetBool ("Grounded", grounded);
		anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal")));

		if (Input.GetAxis ("Horizontal") < 0.1f) {
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (Input.GetAxis ("Horizontal") > 0.1f) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
		if (Input.GetButtonDown("Jump") && grounded == true)
        {
			rb2d.AddForce(Vector2.up * jump_power);
        }

	}


    void FixedUpdate()
    {
		float h = Input.GetAxis ("Horizontal");
		rb2d.AddForce ((Vector2.right * speed) * h);
		if (rb2d.velocity.x > max_speed) 
		{
			rb2d.velocity = new Vector2 (max_speed, rb2d.velocity.y);
		}

		if (rb2d.velocity.x < -max_speed) 
		{
			rb2d.velocity = new Vector2 (-max_speed, rb2d.velocity.y);
		}


    }

}
