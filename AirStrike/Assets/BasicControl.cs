using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {
	public GameObject AirCraft;
	public GameObject rayCastOrigin;
	public GameObject LMissile;
    public GameObject RMissile;

	bool Launch=false;
	public GameObject LeftMissilePos;
    public GameObject RightMissilePos;
	//public float AngleX,AngleY,AngleZ;
	// Use this for initialization
	void Start () {
		}
	
	// Update is called once per frame
	void Update ()
    {


        gameObject.transform.Translate(-transform.right*0.5f);

		if (Input.GetKeyUp (KeyCode.Space)) {
			Launch=true;		
		
		}
		
			if(Launch)
			{

                //LeftMissileLaunch();
                GameObject missileClone;
                missileClone = (GameObject)Instantiate(LMissile, LeftMissilePos.transform.position, LMissile.transform.rotation);

                Rigidbody rg = missileClone.GetComponent<Rigidbody>();


                // left missile
                rg.AddForce(-1400, -1200, 150);

                Launch = false;
                // right missile
                //rg.AddForce(-1400,-1200,-150);
                //rg.velocity = Vector3.zero;

				


			}
			

		
		
	if(Input.GetKey(KeyCode.LeftArrow))
		   {

			AirCraft.transform.position=new Vector3(AirCraft.transform.position.x,AirCraft.transform.position.y,AirCraft.transform.position.z-1);
		}
		if(Input.GetKey(KeyCode.RightArrow))
            
		   {
			
			AirCraft.transform.position=new Vector3(AirCraft.transform.position.x,AirCraft.transform.position.y,AirCraft.transform.position.z+1);
		}
		
	}



    void LeftMissileLaunch()
    {

        GameObject missileClone;
        missileClone = (GameObject)Instantiate(LMissile, LeftMissilePos.transform.position, LMissile.transform.rotation);

        Rigidbody rg = missileClone.GetComponent<Rigidbody>();
       

        // left missile
        rg.AddForce(-1400, -1200, 150);

        
    
    }


}
