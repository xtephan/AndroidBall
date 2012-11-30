using UnityEngine;
using System.Collections;

public class MenuScript : MonoBehaviour {
	
	//RayCast vars
	RaycastHit myhit = new RaycastHit();
    Ray myray = new Ray();
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButtonDown(0)) {
			
			 myray = Camera.main.ScreenPointToRay(Input.mousePosition);
			 
		     if (Physics.Raycast(myray, out myhit)) 	
				if(myhit.transform.name == "PlayButton") 
					Application.LoadLevel("mainGame");
	
			
		}
		
	}
}
