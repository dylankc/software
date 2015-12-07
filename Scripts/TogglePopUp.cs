using UnityEngine;
using System.Collections;

public class TogglePopUp : MonoBehaviour {

	public GameObject popUpWindow;
	
	void OnClick ()
	{
		if (popUpWindow)
		{
			if (popUpWindow.activeSelf)
			{
				popUpWindow.SetActive (false);
			}
			else
			{
				popUpWindow.SetActive (true);
			}
		}
	}
}
