using UnityEngine;
using System.Collections;

public class MissileLaucnhed : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.rotation = Quaternion.Euler(0, 0, 135);
	}

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "box" || col.gameObject.tag == "terrain" || col.gameObject.tag == "plane")
        {
            Destroy(this.gameObject);
         

        }


    }



}
