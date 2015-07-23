using UnityEngine;
using System.Collections;

public class SAM : MonoBehaviour
{

    Rigidbody rg_obj;
    public GameObject StartPosition;
    public GameObject centerMissile;
    public GameObject PlayerAircraft;
    public float HitDistance=100;
    float calculatedDistance = 0;
    bool isLaunched = false;
    public GameObject SAMComponent;
    public GameObject ParentObject;
    public float X;
    // Use this for initialization
    void Start()
    {

        X = 0;

        StartPosition.transform.rotation = Quaternion.Euler(0, 0, 315);

        rg_obj = centerMissile.GetComponent<Rigidbody>();

       


    }

    // Update is called once per frame
    void Update()
    {


        if (rg_obj.velocity.y <= 0)
        {

            Blast();

        }


        if (centerMissile.transform.position == StartPosition.transform.position)
        {

            isLaunched = false;      
        
        
        }

       

        if (canHit() && !isLaunched)
            LaunchCenterMissile();



       
        
        
      
      




    }

    
    bool canHit()
    {


     calculatedDistance = (PlayerAircraft.transform.position - StartPosition.transform.position).magnitude;


       
        if (calculatedDistance < HitDistance)
        {



            return true;

        }
        else
        {


            return false;
        
        }
    
    
    }

    void LaunchCenterMissile()
    {


        //GameObject cloneMissile = (GameObject)Instantiate(centerMissile, StartPosition.transform.position, centerMissile.transform.rotation);
        Blast();
        
        if (rg_obj.velocity.x != 0 || rg_obj.velocity.y != 0 || rg_obj.velocity.z != 0)
        {

            rg_obj.velocity = Vector3.zero;
            rg_obj.angularVelocity = Vector3.zero;
        
        
        
        }
        

        //Vector3 inc=new Vector3(X,0,0);
        //rg_obj.useGravity = true;
        //centerMissile.transform.LookAt(PlayerAircraft.transform.position);
        //rg_obj.AddForce((centerMissile.transform.forward+inc)*8000);


        rg_obj.useGravity = true;




        int randomZ = Random.Range(-1000, 1000);

        rg_obj.AddForce(1500, 1200, randomZ);
        
        
        isLaunched = true;    
    
    
    
    }




    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "missile"  )
        {


            Destruct();

        }


    }
    void Blast()
    {

        //rg_obj.useGravity = false;
        centerMissile.transform.position = StartPosition.transform.position;
        centerMissile.transform.rotation = StartPosition.transform.rotation;
        isLaunched = false;      
        
    // Code for blast
        //Destroy(gameObject);
    
    
    }
    void Destruct()
    {

        Destroy(SAMComponent);
        Destroy(gameObject);
    
    
    
    }
    public void OnDestroy()
    {
        Destroy(ParentObject);
    }
    
}
