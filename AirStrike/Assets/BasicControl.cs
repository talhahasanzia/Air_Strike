using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {
	public GameObject AirCraft;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if(Input.GetKeyUp(KeyCode.LeftArrow))
		   {

			AirCraft.transform.position=new Vector3(AirCraft.transform.position.x,AirCraft.transform.position.y,AirCraft.transform.position.z-10);
		}
		if(Input.GetKeyUp(KeyCode.RightArrow))

		   {
			
			AirCraft.transform.position=new Vector3(AirCraft.transform.position.x,AirCraft.transform.position.y,AirCraft.transform.position.z+10);
		}
		if (Input.GetKeyUp (KeyCode.UpArrow)) {
		
			AirCraft.transform.position=new Vector3(AirCraft.transform.position.x-10,AirCraft.transform.position.y,AirCraft.transform.position.z);

		
		}
		if (Input.GetKeyUp (KeyCode.DownArrow)) {
			
			AirCraft.transform.position=new Vector3(AirCraft.transform.position.x+10,AirCraft.transform.position.y,AirCraft.transform.position.z);
			
			
		}
	}
}
