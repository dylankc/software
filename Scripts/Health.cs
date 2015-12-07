using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour 
{

	private static int health;

	
	public Canvas quitMenu;
	public Button startText;
	public Button exitText;
	private Text frontLabel;


	
	public GUIStyle changeGUI;



	void Start()
	{
		//quitMenu = quitMenu.GetComponent<Canvas> ();
		//startText = startText.GetComponent<Button> ();
		//exitText = exitText.GetComponent<Button> ();
		//quitMenu.enabled = false;
		//exitText.enabled = false;
		//startText.enabled = false;

		frontLabel = GameObject.Find ("Front_Label").GetComponent<Text> ();
		frontLabel.enabled = true;







	




	}


	void onGUI()
	{
		health = Hangman.playerHealth;
		{
			if (health <= 0) {
				GUI.TextField (new Rect (0, 0, 750, 550), "You have lost this battle of .", changeGUI);
				
				//Hangman.hiddenWord = "";
				//Hangman.randomWord.text = "";
				
				if (GUI.Button (new Rect (50, 50, 100, 25), "Start Over")) 
					
					Application.LoadLevel (0);
				
			}
		}
	}
}
	

	/*	Pause Menu

	if (Input.GetKeyDown ("space")) 
	{
			menuImg.enabled = true;
			//quitMenu.enabled = true;
			//startText.enabled = true;
			//exitText.enabled = true;


		}


}
}*/

	

	
	
	






