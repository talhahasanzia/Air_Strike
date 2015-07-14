using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour {

    int Speed;
    int Gravity;
    public Vector3 MoveDirection;
    public CharacterController Con;
    
    // Use this for initialization
	void Start () {

        Speed = 6;
        Gravity = 20;
        MoveDirection = Vector3.zero;
        Con = this.GetComponent<CharacterController>();

	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (Con.isGrounded)
        {

            MoveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
            MoveDirection = transform.TransformDirection(MoveDirection);
        
        }

        float rotateY=(Input.GetAxis("Mouse X")*200)*Time.deltaTime;
        Con.transform.Rotate(0, rotateY, 0);

        MoveDirection.y -= Gravity * Time.deltaTime;

        Con.Move(MoveDirection*Time.deltaTime);

	}
}
