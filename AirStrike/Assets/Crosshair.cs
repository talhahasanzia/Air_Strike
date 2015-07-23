using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {


    public Texture2D crosshairImage;
    public GameObject CameraPosition;
     public float xMin;
     public float yMin;
	// Use this for initialization
	void Start () {
	


        



	}
	
	// Update is called once per frame
	void Update () {
        //this.transform.position = new Vector3(CameraPosition.transform.position.x, CameraPosition.transform.position.y, CameraPosition.transform.position.z);

        
	
	}
    void OnGUI()
    {
         xMin = (Screen.width / 2) - (crosshairImage.width / 2);
        yMin = ((Screen.height / 2) - (crosshairImage.height / 2))*(0.6f);
        GUI.DrawTexture(new Rect(xMin, yMin, crosshairImage.width, crosshairImage.height), crosshairImage);
    }
}
