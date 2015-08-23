using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour{
	// Normal Movements Variables
	public float speed;

	Animator anim;

	void Start()
	{
		anim = GetComponent<Animator> ();
	}
	
	void FixedUpdate()
	{	
		// Move sentence
		GetComponent<Rigidbody2D>().velocity = new Vector2((Input.GetAxisRaw("Horizontal")* speed), (Input.GetAxisRaw("Vertical")* speed));

		//Animation
		if ((Input.GetAxisRaw ("Horizontal")) != 0 || (Input.GetAxisRaw ("Vertical")) != 0) {
			anim.SetFloat ("Speed", 1);
		} else {
			anim.SetFloat ("Speed", 0);
		}

		if ((Input.GetAxisRaw ("Vertical")) == 0) {
			anim.SetBool("Down?", false);
			anim.SetBool("Up?", false);
		}
		if ((Input.GetAxisRaw ("Horizontal")) == 0) {
			anim.SetBool("Right?", false);
			anim.SetBool("Left?", false);
		}

		if ((Input.GetAxisRaw ("Vertical")) < 0) {
			anim.SetBool("Down?", true);
		}else if ((Input.GetAxisRaw ("Vertical")) > 0) {
			anim.SetBool ("Up?", true);
		}
		if ((Input.GetAxisRaw ("Horizontal")) < 0) {
			anim.SetBool("Left?", true);
		}else if ((Input.GetAxisRaw ("Horizontal")) > 0) {
			anim.SetBool ("Right?", true);
		}

	}
}