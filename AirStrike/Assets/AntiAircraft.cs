using UnityEngine;
using System.Collections;

public class AntiAircraft : MonoBehaviour {

	Rigidbody rg_obj;

	int randomX,randomZ;
	// Use this for initialization
	void Start () {
		rg_obj = gameObject.GetComponent<Rigidbody> ();	
		randomX = Random.Range (-120, 120);
		randomZ = Random.Range (-70, 70);
		rg_obj.AddForce(randomX,1500,randomZ);
	}
	
	// Update is called once per frame
	void Update () {
	
		if (rg_obj.velocity == Vector3.zero) {
		

		
		
		}
	}
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "terrain" || col.gameObject.tag == "plane")
			Destroy (gameObject);


	}
}
