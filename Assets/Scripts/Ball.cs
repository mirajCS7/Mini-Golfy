using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
//public float launchSpeed;
private Rigidbody rigidBody;
	public Vector3 launchVelocity = new Vector3 (0,0,0);

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
		// rigidBody.velocity = new Vector3 (launchSpeed,0, launchSpeed);

	}
	
	// Update is called once per frame
	void Update () {
		if (this.rigidBody.velocity.magnitude == 0) {
			
			// when spacebar is held down
			if (Input.GetKey(KeyCode.Space)){
					
				// incriment launch velocity
				launchVelocity.x++;
				launchVelocity.z++;

			// assign to ball
			}
			rigidBody.velocity = launchVelocity;
			launchVelocity.x = 0;
			launchVelocity.z = 0;


		}
	}
}