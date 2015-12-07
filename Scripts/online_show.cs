using UnityEngine;
using System.Collections;

public class online_show : MonoBehaviour 
{
	string url = "http://roundorama.com/wp-content/uploads/2009/10/istocktomato11.jpg";
	Texture2D img;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (LoadImg ());
	
	}

	IEnumerator LoadImg()
	{
		yield return 0;
		WWW imgLink = new WWW (url);
		yield return imgLink;
		img = imgLink.texture;
	}
	
	// Update is called once per frame
	void OnGUI () 
	{
		GUILayout.Label (img);
	
	}
}
