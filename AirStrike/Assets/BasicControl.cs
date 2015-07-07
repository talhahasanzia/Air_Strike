using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {
	public GameObject AirCraft;
	public GameObject rayCastOrigin;
	public GameObject Missile;
	bool Launch=false;
	public GameObject empty_obj;
	//public float AngleX,AngleY,AngleZ;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update ()
    {

		


		if (Input.GetKeyUp (KeyCode.Space)) {
			Launch=true;		
		
		}
		
			if(Launch)
			{

				GameObject missileClone;

				missileClone=(GameObject)Instantiate(Missile,empty_obj.transform.position,Missile.transform.rotation);

				Rigidbody rg=missileClone.GetComponent<Rigidbody>();
				// right missile
				//rg.AddForce(-1400,-1200,-150);
                rg.velocity = Vector3.zero;

				// left missile
				rg.AddForce(-1400,-1200,150);

				Launch=false;


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
