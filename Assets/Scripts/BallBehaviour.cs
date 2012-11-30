using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {
	
	public MainGame mainGameScript;
	
	// Use this for initialization
	void Start () {
		// Apply initial force 
		rigidbody.AddForce(4,4,0,ForceMode.Impulse);
		
		//Increase the ball's velocity 
		InvokeRepeating("IncreaseBallVelocity",2,2);
	}
	
	// Update is called once per frame
	void Update () {
		
		// If ball is under the paddle
		// Hardcoded y coordonates
		if(transform.position.y < -6)		
			mainGameScript.GameOver();
		
	}
	
	
	//Increase ball velocity method
	void IncreaseBallVelocity() {
		
		rigidbody.velocity *= 1.05f;
		
		//Debug.Log("velocity: " + rigidbody.velocity);
	}
}
