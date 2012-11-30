using UnityEngine;
using System.Collections;

public class bonusAreaDetectionBoxScripts : MonoBehaviour {
	
	//public vars
	public MainGame mainGameScript;
	public GameObject particles_square;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	public void OnTriggerEnter(Collider collision) {
		
		if( collision.transform.name == "Ball" ) {
			Instantiate(particles_square, transform.position, transform.rotation);
			audio.Play();
			mainGameScript.AddBonusScore();
		}
	
	}
}
