using UnityEngine;
using System.Collections;

public static class GameOverGui {
	public static void InitGUI () {

	}

	public static void DrawGUI () {
		GUI.Label (new Rect (Screen.width / 2 - GUIManager.gridWidth / 2, Screen.height / 3, GUIManager.gridWidth, GUIManager.gridHeight), "Game Over");
		if (GUI.Button (new Rect (Screen.width / 2 - GUIManager.gridWidth * 3 / 2, Screen.height / 2, GUIManager.gridWidth, GUIManager.gridHeight), "Load a game")) {
			Debug.Log ("Load a game pressed");
		}
		if (GUI.Button (new Rect (Screen.width / 2 + GUIManager.gridWidth / 2, Screen.height / 2, GUIManager.gridWidth, GUIManager.gridHeight), "Back to Main Menu")) {
			MainManager.InitAllManagers();
		}
	}
}