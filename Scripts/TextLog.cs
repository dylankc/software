using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Linq;
using System.Text;


public class TextLog : MonoBehaviour 
{
	//public GameObject _Effit;
	//public Text Text1;
	//public Text Text2;
	// public Text iField;

	//maybe change
	public string kCheck;
	public string kCode;

	public string[] keys =
	
	{
		"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
		"m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", 
		"y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
	};

	public string[] keys2 =
		
	{
		"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l",
		"m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", 
		"y", "z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
	};

}



		//GameObject.Find ("alphaText").GetComponent<Text>;

/*	public void Start()
	{
	//	iField.text = " ";

		detectPressedKeyOrButton ();

			
	}
*/
//	public void detectPressedKeyOrButton ()
//	{


	//	GameObject panel = GameObject.Find ("Panel");

	//	Text[] txtValue = panel.GetComponentsInChildren<Text> ();

		//GameObject.Find ("alphaText").GetComponent<Text>();

	//	Text[] txtValue = GameObject.Find ("Panel").GetComponentInChildren<Text> ();

//		List<string> names = new List<string> ();

//		GameObject panel = GameObject.Find ("Panel");
		
//		Text[] txtValue = panel.GetComponentsInChildren<Text> ();

//	public List<string> names = new List<string>();

	/*
	void Start() {
//		detectPressedKeyOrButton();
	}




			//List<string> names = new List<string> ();
	//		var names = new List<KeyCode> ();

/*			var txtValue = GameObject.Find ("Store_Text").GetComponentInChildren<Text> ();

			if (Input.anyKeyDown)
		

				foreach (KeyCode kCode in System.Enum.GetValues(typeof(KeyCode))) 
		
					if (Input.GetKey (kCode))
			
						names.Add (kCode.ToString());


//				Debug.Log ("kCode.ToString is " + kCode.ToString());
//				Debug.Log ("kCode is " + kCode);
			Debug.Log ("txtValue is " + txtValue);
			Debug.Log ("txtValue.text " + txtValue.text);
//				Debug.Log (names.Add(kCode));
		Debug.Log (names.Contains (


			




				//if(kCode = txtValue.text)
				//{
				//	Debug.Log ("key match"


			

//		}

}


		for (int k = 0; k < keys2.Length; k++) 
			{



				Debug.Log ("For Loop with k");

				if (Input.GetKeyDown (kCheck))
				{
					var kCheck = keys2 [k];			

					kCheck.ToString();

					for(int j = 0; j < txtValue.Length; j++) 
			
					{

						var jCheck = txtValue[j];
							
						Debug.Log ("For Loop with j");

			 //67 || (Input.GetKeyDown(kCode))) 
				

					
						
					//67	kCode.ToString();

				
						if (kCheck.Equals(jCheck)) 
				
						{
							Debug.Log ("SAME KEY");

							jCheck.text += kCheck.ToString();

			//		names.Add(kCheck.ToString ());

				//	names.Add (kCode.ToString());
				
						}  
				
				{

				}
				
			}
		}

			else
			{

			Debug.Log ("DIFF KEY");
			}
		}
	}
}

*/





		

			













		//GameObject.Find ("alphaText").GetComponent<Text>();
		//detectPressedKeyOrButton ();
	/*
	public void detectPressedKeyOrButton()
	{
		//List<string> names = new List<string> ();

	checkText = GameObject.Find ("Store_Text").GetComponent<Text> ();

	var checkText = firstWord.text.ToString ();



		foreach (KeyCode kcode in Enum.GetValues(typeof(KeyCode))) 
		{
			for (int i = 0; i < keys.Length ; i++)
			{

				if (Input.GetKeyDown (kcode)) 
				
				{
					iField.text += kcode.ToString();

//					Debug.Log (kcode);

				

					names.Add(kcode.ToString ());

				
				
				
				//same as Debug.Log ("KeyCode down: " + kcode);
//				Debug.Log (kcode.ToString());
				
				//names.Add (kcode.ToString(GameObject.Find ("iField").GetComponent<Text>().text)); 
	//			iField.text = myName[i].ToString();


//					myName.ToString() = iField.text;
				}

				



		//		Text1.ToString() = names[0];


					i++;
			}
		}

				
		
	}
}
}
	void OnGUI()
//	{
//		GUI.Label (new Rect (50, 50, 100, 50), "Test: " + kcode);
//	}

}

				 





//	degreeDictionary.Add(kcode, new string[] {});



				//	for (int a = 0; a < Text1.Length; a++) 
		//		{



				//				var input = gameObject.GetComponent<InputField> ();

//				var se = new InputField.SubmitEvent ();

//				se.AddListener (SubmitName);

//				input.onEndEdit = se;




				//	Text2 = GameObject.Find ("alphaText").GetComponent<Text> ();

*/

