using UnityEngine;
using System.Collections;

public class AntiAircraft : MonoBehaviour {

	Rigidbody rg_obj;
    public GameObject StartPosition;

	int randomX,randomZ;
	// Use this for initialization
	void Start () {


       
        rg_obj = gameObject.GetComponent<Rigidbody>();
        randomX = Random.Range(-120, 120);
        randomZ = Random.Range(-70, 70);
        rg_obj.AddForce(randomX, 1800, randomZ);
            

        
        
            
        
	}
	
	// Update is called once per frame
	void Update () {

        

        if (gameObject.transform.position.y == StartPosition.transform.position.y)
        {
            rg_obj = gameObject.GetComponent<Rigidbody>();
            rg_obj.velocity = Vector3.zero;
            randomX = Random.Range(-120, 120);
            randomZ = Random.Range(-300, 300);
            rg_obj.AddForce(randomX, 1800, randomZ);
        }          



        
        
      




			}
	void OnCollisionEnter(Collision col)
	{
        if (col.gameObject.tag == "terrain" || col.gameObject.tag == "plane" || gameObject.transform.position.y>20)
        {
            gameObject.transform.position = StartPosition.transform.position;
            
            //Destroy(gameObject);

           
        }


	}
}
