using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;
	private Rigidbody rb;

	// At the start of the game..
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        movement = Camera.main.transform.TransformDirection(movement);
        movement.y = 0;
        Vector3 force = movement.normalized * speed;

        rb.AddForce (movement * speed);
	}

}
