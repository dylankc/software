#pragma strict

var menu01Prefab : GameObject;
var menu02Prefab : GameObject;
var menu03Prefab : GameObject;

var savedMenu : int = 0;

function Awake()
{
	savedMenu = PlayerPrefs.GetInt("selectedMenuObject");
	
	menu01Prefab = GameObject.Find("Menu 1");
	menu02Prefab = GameObject.Find("Menu 2");
	menu03Prefab = GameObject.Find("Menu 3");
	
	if(savedMenu == 0)
	{
		menu01Prefab.SetActive(true);
		menu02Prefab.SetActive(false);
		menu03Prefab.SetActive(false);
	}
	else if (savedMenu == 1)
	{
		menu01Prefab.SetActive(true);
		menu02Prefab.SetActive(false);
		menu03Prefab.SetActive(false);
	}
	else if (savedMenu == 2)
	{
		menu02Prefab.SetActive(true);
		menu01Prefab.SetActive(false);
		menu03Prefab.SetActive(false);
	}
	else if (savedMenu == 3)
	{
		menu03Prefab.SetActive(true);
		menu02Prefab.SetActive(false);
		menu01Prefab.SetActive(false);
		}
}