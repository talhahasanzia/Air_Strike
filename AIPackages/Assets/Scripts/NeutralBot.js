var awareDistance :float = 15.0;
var scaredDistance :float = 10.0;
var player :Transform;

var runSpeed :float = 4.0;

enum AIStatus {Idle = 0, Scared = 1}
private var status = AIStatus.Idle;

var controller :CharacterController;

private var moveDirection = Vector3.zero;

function Awake()
{
	controller = GetComponent(CharacterController);

}


function Update()
{
	CheckStatus();
	
	switch(status)
	{
		case AIStatus.Idle:
		Idle();
		break;
		
		case AIStatus.Scared:
		RunAway();
		break;
		
	}
	
}

function Idle()
{
	animation.CrossFade ("idle");
}

function RunAway()
{
	transform.eulerAngles.y = -player.transform.eulerAngles.y;
	moveDirection = Vector3(0,0,40);	
	moveDirection = transform.TransformDirection(moveDirection);	
	moveDirection *= runSpeed;	
	controller.SimpleMove(moveDirection * Time.deltaTime);
	
	animation.CrossFade ("run");
	
}

function CheckStatus()
{
	
	var dist = (player.position - transform.position).magnitude;
	
	if(dist < scaredDistance)
	{
		status = AIStatus.Scared;
	}
	
	else if (dist > awareDistance)
	{
		status = AIStatus.Idle;
	}

}