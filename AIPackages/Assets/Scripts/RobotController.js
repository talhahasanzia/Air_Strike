var speed : int = 6;

var gravity :int = 20;

private var moveDirection = Vector3.zero;

function FixedUpdate()
{
	var controller :CharacterController = GetComponent(CharacterController);
	
	if(controller.isGrounded)
	{
		moveDirection = Vector3(0,0, Input.GetAxis("Vertical"));
		moveDirection = transform.TransformDirection(moveDirection);
		moveDirection *= speed;
	}
	
	
	var rotateY = (Input.GetAxis("Mouse X") * 200) * Time.deltaTime;
	
	controller.transform.Rotate(0,rotateY, 0);
	
	moveDirection.y -= gravity * Time.deltaTime;
	
	controller.SimpleMove (moveDirection * Time.deltaTime);
}