using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Linq;
using System.Text;

public class Hangman : MonoBehaviour {

	public Text displayLife;
	
	public Text randomWord;           
	public string hiddenWord = string.Empty;           
	public string inputChar;     

	public static int playerHealth;
	bool starter;

	public static GameObject leftArm;
	public static GameObject rightArm;
	public static GameObject leftLeg;
	public static GameObject rightLeg;
	public static GameObject head;
	public static GameObject body;
	
	public GUIStyle changeGUI;
	public Image splashScreen;

	private bool showPopUp = false;

	public int i;


	 
	
	
	void Start () 
	{

		//6 body parts on Hangman's Body: Head/Body/Right Leg/Left Leg/Right Arm/Left Arm;
		//bodyparts represented by parts of Skyrim dragon.
		playerHealth = 6; 
	
		//This instantiates unguessed letter as dashes to show progess.
		for (int i 	= 0; i < randomWord.text.ToString().Length; i++)	
			hiddenWord += "-";

		//This is the spash screen that displays once health = 0.
		splashScreen = GameObject.Find ("Image").GetComponent<Image> ();
		splashScreen.enabled = false;

		//This is the message on the endgame splash screen to show what the word was.
		displayLife = GameObject.Find ("newtext").	GetComponent<Text> ();
	 

	}

	
	//Check if the random word contain any character typed in the input text field
	void CheckChar () 
	{
		int charIndex = 0;

		for (int i = 0; i < randomWord.text.ToString().Length; i++) {
			
			var getEm = randomWord.text;
			
			if (getEm[i].ToString() == inputChar) {
				

				//index for locating position of correct guess
				charIndex = i;
				
				//Remove character that has been found
				hiddenWord = hiddenWord.Remove (charIndex, 1);
				
				//Assign the correct char to the full result string
				hiddenWord = hiddenWord.Insert (charIndex, inputChar);
				

//				unused code to represent each character as a different object
				//goGetter = GameObject.Find ("ob" + charIndex).GetComponent<Text> ();
				
				//GameObject = LetterChooser._letComp.enabled=true;
//				goGetter.enabled = true;
				
				
				//	Debug.Log ("Correct Char: " + hiddenWord [charIndex]); 
				
			}
		}
		
		// Success or Fail flow 
		if (hiddenWord.Contains (inputChar)) {
			//Debug.Log ("YES");
			Debug.Log ("Player Health " + playerHealth);
		}
		
		if (!hiddenWord.ToString ().Contains (inputChar)) {
			Debug.Log ("Player Health " + playerHealth);
			playerHealth--;
			
			//case statment to delete body part when guess is wrong
				
			playerHealth = Mathf.FloorToInt(playerHealth);
			
			switch (playerHealth) {
			case 5:
				var rightLeg = GameObject.Find ("right_leg").GetComponent<MeshRenderer> ();
				rightLeg.enabled = false;
				displayLife.text = "5 attempts left";
				break;
			case 4:
				var leftLeg = GameObject.Find ("left_leg").GetComponent<MeshRenderer> ();
				leftLeg.enabled = false;
				displayLife.text = "4 attempts left";
				break;
			case 3:
				var rightArm = GameObject.Find ("right_arm").GetComponent<MeshRenderer> ();
				rightArm.enabled = false;
				displayLife.text = "3 attempts left";
				break;
			case 2:
				var leftArm = GameObject.Find ("left_arm").GetComponent<MeshRenderer> ();
				leftArm.enabled = false;
				displayLife.text = "2 attempts left";
				break;
			case 1:
				var body = GameObject.Find ("body").GetComponent<MeshRenderer> ();
				body.enabled = false;
				displayLife.text = "1 attempt left";
				break;
			case 0:
				var head = GameObject.Find ("head").GetComponent<MeshRenderer> ();
				head.enabled = false;
				Debug.Log ("LOSTT");
				displayLife.text = "The name of the battle lost today: \n\n" + LetterChooser.firstWord.text;
				break;
			}
		}
	}

	
	//display interface to type in guess
	void OnGUI () {

		

		//shows progress as player enters in guess
		GUI.Label (new Rect (2, 15, 100, 100), hiddenWord);
		GUI.TextField (new Rect (450, 335, 100, 25), hiddenWord, hiddenWord.ToString().Length);
		GUI.TextField (new Rect (5, 15, 100, 25), " ", changeGUI);
		
		
		//The character the player can input (limited to one char only)
		inputChar = GUI.TextField (new Rect (5, 325, 100, 25), inputChar, 1);


		if (GUI.Button (new Rect (130, 325, 100, 25),"Submit")) 
		{
			//Prevent char to be sent if null
			if (!string.IsNullOrEmpty (inputChar))
				CheckChar ();

			//Reset input char to empty
			inputChar = "";

		}
	
		if (playerHealth <= 0) {
		

			//reset variables for new game
			hiddenWord = "";
			randomWord = null;

			splashScreen.enabled = true;

			//button to reset once player has put in wrong letter 6 times
			if (GUI.Button (new Rect (250, 200, 300, 50), "You Lost This Battle. Click Here To Try again")) 
			{
				Application.LoadLevel (0);

			}
		}
	}
}

	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
	
			

		

		




