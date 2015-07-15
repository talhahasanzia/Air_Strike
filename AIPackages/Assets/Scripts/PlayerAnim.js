private var run :String = "run";

function Start ()
{
	animation.wrapMode = WrapMode.Loop;
}

function Update()
{
	if(Input.GetAxis("Vertical") > 0.2)
	{
		animation[run].speed = 1.0;
		animation.CrossFade (run);
	}
	
	else if(Input.GetAxis("Vertical") < -.2)
	{
		animation[run].speed = -1.0;
		animation.CrossFade (run);
	}
	
	else
	{
		animation.CrossFade("idle");
	}
	
}
