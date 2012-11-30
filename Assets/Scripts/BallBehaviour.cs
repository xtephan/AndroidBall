using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {
	
	//public vars
	public MainGame mainGameScript;
	public GameObject particles_spark;
	
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
		if(transform.position.y < -6.5f)		
			mainGameScript.GameOver();
		
	}
	
	
	//Increase ball velocity method
	void IncreaseBallVelocity() {
		
		rigidbody.velocity *= 1.05f;
		
		//Debug.Log("velocity: " + rigidbody.velocity);
	}
	
	// Particles splash on collision
	void OnCollisionEnter(Collision collision) {
		Instantiate(particles_spark,transform.position,transform.rotation);
		audio.Play();
	}
}
