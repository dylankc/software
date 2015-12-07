using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour 
{
	public float moveSpeed = 100f;
	public float turnSpeed = 50f;

	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey (KeyCode.UpArrow))
			transform.Translate (Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.DownArrow))
			transform.Translate (-Vector3.forward * moveSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.LeftArrow))
			transform.Rotate (Vector3.up, -turnSpeed * Time.deltaTime);

		if (Input.GetKey (KeyCode.RightArrow))
			transform.Rotate (Vector3.up, turnSpeed * Time.deltaTime);
	
	}
}
