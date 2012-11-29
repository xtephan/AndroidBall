using UnityEngine;
using System.Collections;

public class BallBehaviour : MonoBehaviour {

	// Use this for initialization
	void Start () {
		rigidbody.AddForce(4,4,0,ForceMode.Impulse);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
