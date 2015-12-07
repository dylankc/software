#pragma strict

var selectedMenuObject : int = 0;

function Update()
{
	if (Input.GetMouseButtonDown (0))
	{
		var ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		var hit : RaycastHit;
		
		if (Physics.Raycast (ray, hit, 100))
		{
		
			if(hit.collider.name == "Menu 1")
			SelectedMenuObject1();
			
			if(hit.collider.name == "Menu 2")
			SelectedMenuObject2();
			
			if(hit.collider.name == "Menu 3")
			SelectedMenuObject3();
		}
		else
		{
		return;
		}
	}
}

function SelectedMenuObject1() 
{
	selectedMenuObject = 1;
	PlayerPrefs.SetInt("selectedMenuObject", (selectedMenuObject));
}

function SelectedMenuObject2() 
{
	selectedMenuObject = 2;
	PlayerPrefs.SetInt("selectedMenuObject", (selectedMenuObject));
}

function SelectedMenuObject3() 
{
	selectedMenuObject = 3;
	PlayerPrefs.SetInt("selectedMenuObject", (selectedMenuObject));
}



			
