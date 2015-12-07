using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class buttonTurnColor : MonoBehaviour 
{
	Image image;

	void Start()
	{
		image = GetComponent<Image> ();
	}

	public void Red()
	{
		image.color = Color.red;
	}

	public void Blue()
	{
		image.color = Color.blue;
	}
}
