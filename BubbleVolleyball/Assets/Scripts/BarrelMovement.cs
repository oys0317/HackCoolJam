using UnityEngine;
using System.Collections;

public class BarrelMovement : MonoBehaviour {
	public float speed = 1f;

	Rigidbody2D barrelRB;

	// Use this for initialization
	void Start () {	
		barrelRB = GetComponent<Rigidbody2D>();
		barrelRB.velocity = speed * new Vector2 (0f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
