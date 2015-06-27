using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {
	public GameObject AirCraft;
	public GameObject rayCastOrigin;
	public GameObject Missile;
	bool Launch=false;
	//public float AngleX,AngleY,AngleZ;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update ()
    {

		RaycastHit info;


		if (Input.GetKeyUp (KeyCode.Space)) {
			Launch=true;		
		
		}
		if (Physics.Raycast (rayCastOrigin.transform.position,Quaternion.Euler(0,0,135) * transform.up ,out info,100)) {
		
			Debug.DrawLine(rayCastOrigin.transform.position,info.point);

			if(Launch)
			{

				GameObject missileClone=Missile;

				Instantiate(missileClone,Missile.transform.position,missileClone.transform.rotation);
				Launch=false;

			}
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
