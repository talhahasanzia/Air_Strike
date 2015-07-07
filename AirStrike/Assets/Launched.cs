using UnityEngine;
using System.Collections;

public class Launched : MonoBehaviour {
	public Vector3 target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


        transform.rotation = Quaternion.Euler(0, 0, 135);
	}
	void OnCollisionEnter(Collision col)
	{

		if(col.gameObject.tag=="box" || col.gameObject.tag=="terrain")
		   {
			Destroy(this.gameObject);

		}


	}
}
