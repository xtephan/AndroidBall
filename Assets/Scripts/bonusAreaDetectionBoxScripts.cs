using UnityEngine;
using System.Collections;

public class bonusAreaDetectionBoxScripts : MonoBehaviour {
	
	//public vars
	public MainGame mainGameScript;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	public void OnTriggerEnter(Collider collision) {
		if( collision.transform.name == "Ball" )
			mainGameScript.AddBonusScore();
	}
}
