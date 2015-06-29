using UnityEngine;
using System.Collections;

public static class GameOverGui {
	public static void InitGUI () {

	}

	public static void DrawGUI () {
		GUI.Label (new Rect (Screen.width/2 - Screen.width/16, Screen.height/3, Screen.width/8, Screen.height/8), "Game Over");
		if (GUI.Button (new Rect (Screen.width/2 - Screen.width*3/16, Screen.height/2, Screen.width/8, Screen.height/8), "Load a game")) {
			Debug.Log ("Load a game pressed");
		}
		if (GUI.Button (new Rect (Screen.width/2 + Screen.width/16, Screen.height/2, Screen.width/8, Screen.height/8), "Back to Main Menu")) {
			MainManager.InitAllManagers();
		}
	}
}