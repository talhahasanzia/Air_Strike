﻿using UnityEngine;
using System.Collections;

public class Launched : MonoBehaviour {
	public Vector3 target;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward*3*Time.deltaTime);
	}
}