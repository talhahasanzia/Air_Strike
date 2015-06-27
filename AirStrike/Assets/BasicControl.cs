using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {
	public GameObject AirCraft;
	public GameObject rayCastOrigin;
	public float AngleX,AngleY,AngleZ;
	// Use this for initialization
	void Start () {
		AngleX = 0;
		AngleY = 0;
		AngleZ = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		Vector3 targetDir = new Vector3 (45, 0, 0);
		RaycastHit info;
		if (Physics.Raycast (rayCastOrigin.transform.position,Quaternion.Euler(AngleX,AngleY,AngleZ) * transform.forward ,out info,100)) {
		
			Debug.DrawLine(rayCastOrigin.transform.position,info.point);
			Debug.Log("Raycast working");

		
		}
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
