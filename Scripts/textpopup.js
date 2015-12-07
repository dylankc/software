#pragma strict

var text : GameObject;

function Start () 
{
	text.SetActive(false);
}


function OnTriggerEnter()
{
	text.SetActive(true);
}

function OnTriggerExit()
{
	text.SetActive(false);
}

