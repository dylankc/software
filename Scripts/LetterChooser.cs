using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Linq;
using System.Text;


public class LetterChooser : MonoBehaviour 
{

		
	public Text _letComp;

	public static Text firstWord;
	
	public  static Text littleA;

	bool starter = true;
	

	public GameObject mainCanvas;

		


	void Update()
	{
		if (starter == true)
		{
			{		

				//Find object with random word generator
				firstWord = GameObject.Find ("Word").GetComponent<Text> ();

				//convert to string
				var fullWord = firstWord.text.ToString ();
				//Debug.Log (fullWord);
				//Debug.Log (fullWord.Length);

				for (int i = 0;i < fullWord.Length; i++)
				{
				
					//Find object to be instantiated and represent each letter
					var littleA = GameObject.Find ("Tester").GetComponent<Text> ();
	
					//Debug.Log (littleA);

					//location of instantiated objects
					Vector3 rotationText = new Vector3(0, 0, 0);
					Vector3 positionText = new Vector3(250 + 5 * (i * 20), 370, 0);

					//variable and properties assigned to instantiated objects
					Text _letComp = Instantiate ((littleA),  (positionText), Quaternion.Euler (rotationText)) as Text;
					Debug.Log (_letComp);

					_letComp.name = "ob"+i;
					_letComp.tag = "ob";
					_letComp.enabled = false;

					_letComp.transform.parent = mainCanvas.transform;

					_letComp.GetComponent<RectTransform>().localPosition = new Vector3(_letComp.GetComponent<RectTransform>().localPosition.x, 
					                                                                  _letComp.GetComponent<RectTransform>().localPosition.y,
					                                                                  0);

					//Debug.Log (i);
					_letComp.text = GameObject.Find ("Word").GetComponent<Text>().text;
					_letComp.text = fullWord[i].ToString();


				
					starter = false;
				}
			}
		}
	}


}


	