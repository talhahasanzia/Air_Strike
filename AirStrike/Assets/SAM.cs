using UnityEngine;
using System.Collections;

public class SAM : MonoBehaviour
{

    Rigidbody rg_obj;
    public GameObject StartPosition;
    public GameObject centerMissile;

    static bool create = true;
    // Use this for initialization
    void Start()
    {



        if(create)
        LaunchCenterMissile();





    }

    // Update is called once per frame
    void Update()
    {

        


        




        if (rg_obj.velocity.y < 0)

            Blast();
        
        
      
      




    }

    void LaunchCenterMissile()
    {


        GameObject cloneMissile = (GameObject)Instantiate(centerMissile, StartPosition.transform.position, centerMissile.transform.rotation);

        rg_obj = cloneMissile.GetComponent<Rigidbody>();
        rg_obj.useGravity = true;
        
        rg_obj.AddForce(500, 1000, -500);
        create = false;
    
    
    
    }




    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "terrain" || col.gameObject.tag == "plane" )
        {


            Blast();


        }


    }
    void Blast()
    { 
    
    
    // Code for blast
        Destroy(gameObject);
    
    
    }

    public void OnDestroy()
    {
        LaunchCenterMissile();
    }
    
}
