﻿using UnityEngine;
using System.Collections;

public class WhaleMovement : MonoBehaviour {

	public float speed = 1f;  
	Vector3 movement;
	Rigidbody2D whaleRigidbody;
	Animator anim;
	Vector3 endPosition;
		
	// Use this for initialization
	void Awake () {

		whaleRigidbody = GetComponent <Rigidbody2D> ();
		anim = GetComponent <Animator> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");

		Move (h, v);
		Animating (h, v);
		if(Input.GetButton ("Fire1")) {
			Dive();
		}
		//whaleRigidbody.MovePosition (endPosition);
	}

	void Move (float h, float v) {
		movement.Set (h, v, 0f);
		movement = movement.normalized * speed * Time.deltaTime;
		whaleRigidbody.MovePosition (transform.position + movement);
	}

	void Animating (float h, float v) {
		bool moving = h != 0f || v != 0f;
		anim.SetBool ("IsMoving", moving);
	}

	void Dive () {
		anim.SetTrigger ("Dive");
		endPosition = transform.position;
	}
}
