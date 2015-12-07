
function OnGUI()
{
	GUI.Box (Rect (10, 10, 100, 90), "Load Level");

	if (GUI.Button (Rect (20, 40, 80, 20), "Level 1"))
{
	Application.LoadLevel ("Level_01");
	}
}