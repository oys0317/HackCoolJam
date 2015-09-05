using UnityEngine;
using System.Collections;

public class WhaleMovement : MonoBehaviour {

	public float speed = 1f;  
	Vector3 movement;
	Rigidbody whaleRigidbody;

	// Use this for initialization
	void Start () {

		whaleRigidbody = GetComponent <Rigidbody> ();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float h = Input.GetAxisRaw ("Horizontal");
		float v = Input.GetAxisRaw ("Vertical");
		
		// Move the player around the scene.
		Move (h, v);
	}

	void Move (float h, float v){
		movement.Set (h, v, 0f);
		movement = movement.normalized * speed * Time.deltaTime;
		whaleRigidbody.MovePosition (transform.position + movement);
	}
}
