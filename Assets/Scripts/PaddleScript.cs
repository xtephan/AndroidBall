using UnityEngine;
using System.Collections;

public class PaddleScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	

    RaycastHit myhit = new RaycastHit();
    Ray myray = new Ray();
	
	// Update is called once per frame
	void Update () {
	
		if(Input.GetMouseButton(0)) {
			
			 myray = Camera.main.ScreenPointToRay(Input.mousePosition);
			 
		     if (Physics.Raycast(myray, out myhit)) {	
					
				if( myhit.point.x > -2.4 && myhit.point.x < 3.5 ) {
					transform.position = new Vector3(myhit.point.x,transform.position.y,transform.position.z);
				}
			 }
			
		}
		
	}
}
