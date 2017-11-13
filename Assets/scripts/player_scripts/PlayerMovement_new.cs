using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_new : MonoBehaviour {

	private Rigidbody2D rb2d;
	private Animator anim;
	public float speed;
	public float JumpPower;


	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		anim = gameObject.gameObject.GetComponent<Animator> ();
	}

	void FixedUpdate () {
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");


		if (horizontal != 0.0) {

			Debug.Log (horizontal);


		}

		animation (horizontal);

		flip (horizontal);
		movement (horizontal ,vertical);
	}

	void movement (float horizontal, float vertical){


		rb2d.velocity = new Vector2 (horizontal * speed, vertical * JumpPower);
	}




	void flip (float horizontal) // for fliping the player left or right
	{
		if (horizontal < 0) {
			transform.localScale = new Vector3 (-1, 1, 1);
		}
		if (horizontal > 0) {
			transform.localScale = new Vector3 (1, 1, 1);
		}
	}
	void animation(float horizontal){
		anim.SetFloat ("Speed", horizontal * horizontal); 
		// hori * hori because i want the Speed to be always positive

	}


}
