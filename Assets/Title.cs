using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour {

		void OnGUI()
		{
			const int buttonWidth = 88;
			const int buttonHeight = 60;
		GUI.color = Color.white;
			
			// Determine the button's place on screen
			// Center in X, 2/3 of the height in Y
			Rect buttonRect = new Rect(
				Screen.width / 2 - (buttonWidth / 2),
				(2 * Screen.height / 3) - (buttonHeight / 10),
				buttonWidth,
				buttonHeight
				);
	
			// Draw a button to start the game
			if(GUI.Button(buttonRect,"Click to Start"))
			{
				// On Click, load the first level.
				// "Stage1" is the name of the first scene we created.
				Application.LoadLevel("__Bartok_Scene_0");
			}
			
			
			
		}

}


