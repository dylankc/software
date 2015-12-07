using UnityEngine;
using System.Collections;

public class lightoff : MonoBehaviour 
{
	public GameObject theLight = null;

	public void OnMouseDown()
	{
		if(theLight != null)
			theLight.GetComponent<Light>().enabled = !theLight.GetComponent<Light>().enabled;
	}
}


