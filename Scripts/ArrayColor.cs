using UnityEngine;
using System.Collections;

public class ArrayColor : MonoBehaviour {
			
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Space)) {
			GameObject[] cubeArray = GameObject.FindGameObjectsWithTag ("Cube");
			for (int i = 0; i < cubeArray.Length; i++) {
				cubeArray[i].GetComponent<Renderer>().material.color = Color.red;
			}
		}
	}

}
