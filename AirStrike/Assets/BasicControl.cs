using UnityEngine;
using System.Collections;

public class BasicControl : MonoBehaviour {

    public float x = 10, y = -90, z = 0;
    public GameObject ParentObject;
    
    public static int Score;
    public static int Health=100;


    public GameObject AirCraft;
	public GameObject rayCastOrigin;
	public GameObject LMissile;
    public GameObject RMissile;
    RaycastHit RayHit;
    bool SwitchMissile;
	bool Launch=false;
    public bool BothMissiles = false;
	public GameObject LeftMissilePos;
    public GameObject RightMissilePos;
	//public float AngleX,AngleY,AngleZ;
	// Use this for initialization
	void Start () {


        x = 10.6f; y = -90.3f;

		}
	
	// Update is called once per frame
	void Update ()
    {
        AirCraft.transform.rotation = Quaternion.Euler(0, 0, 0);
        Debug.Log("Score:  " + Score + "   Health: "+Health);

        if (Health == 0)
        {

            Debug.Log("");
            Debug.Log("Game Over");
            Destroy(this.gameObject);
        
        
        }
        //if (Physics.Raycast(rayCastOrigin.transform.position, Quaternion.Euler(x, y, z) * transform.forward, out RayHit, Mathf.Infinity))
        //{

        //    Debug.DrawLine(rayCastOrigin.transform.position, RayHit.point, Color.red);
        
        //}

        if((Input.GetKey(KeyCode.UpArrow)))
        {

            ParentObject.transform.Translate(-transform.right * 1f);
            Score += 3;
        
        }
        if ((Input.GetKey(KeyCode.DownArrow)))
        {

            ParentObject.transform.Translate(-transform.right * 0.5f);
            Score += 1;

        }
        else
        {
            // ParentObject.transform.Translate(-transform.right * 0.8f);
            Score += 1;
        }
		if (Input.GetKeyUp (KeyCode.Space)) {
			Launch=true;		
		
		}
		
			if(Launch)
			{



                MissileLaunch();
                Launch = false;

			}
			

		
		
	if(Input.GetKey(KeyCode.LeftArrow))
		   {
               AirCraft.transform.rotation = Quaternion.Euler(320, 0, 0);
               ParentObject.transform.position = new Vector3(ParentObject.transform.position.x, ParentObject.transform.position.y, ParentObject.transform.position.z - 1);
		}
		if(Input.GetKey(KeyCode.RightArrow))
            
		   {
               AirCraft.transform.rotation = Quaternion.Euler(40, 0, 0);
               ParentObject.transform.position = new Vector3(ParentObject.transform.position.x, ParentObject.transform.position.y, ParentObject.transform.position.z + 1);
		}
		
	}



    void MissileLaunch()
    {


        if (BothMissiles)
        {



            GameObject missileLeft;
            missileLeft = (GameObject)Instantiate(LMissile, LeftMissilePos.transform.position, LMissile.transform.rotation);

            Rigidbody rgLeft = missileLeft.GetComponent<Rigidbody>();


            // left missile
            rgLeft.AddForce(-6500, -1200, 250);



            GameObject missileRight;
            missileRight = (GameObject)Instantiate(RMissile, RightMissilePos.transform.position, RMissile.transform.rotation);

            Rigidbody rgRight = missileRight.GetComponent<Rigidbody>();
            // right missile
            rgRight.AddForce(-6500, -1200, -250);




            BothMissiles = false;

        }
        else
        {
            if (SwitchMissile)
            {
                //LeftMissileLaunch();


                GameObject missileLeft;
                missileLeft = (GameObject)Instantiate(LMissile, LeftMissilePos.transform.position, LMissile.transform.rotation);

                Rigidbody rgLeft = missileLeft.GetComponent<Rigidbody>();







                // left missile
                rgLeft.AddForce(-6500, -1200, 250);

                SwitchMissile = false;
            }
            else
            {
                GameObject missileRight;
                missileRight = (GameObject)Instantiate(RMissile, RightMissilePos.transform.position, RMissile.transform.rotation);

                Rigidbody rgRight = missileRight.GetComponent<Rigidbody>();
                // right missile
                rgRight.AddForce(-6500, -1200, -250);
                SwitchMissile = true;
            }
        }
        
    
    }

    public void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "enemy")
        {

            Score += 10;
        
        }
        if (collision.gameObject.tag == "missile")
        {

            Health-= 10;

        }

    }




}
