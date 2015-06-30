using UnityEngine;
using System.Collections;

public static class SquadStatusGui {
	public static void DrawGUI () {
		GUI.Label (new Rect (GUIManager.gridWidth * 4, 0, GUIManager.gridWidth, GUIManager.gridHeight), "Squad " + DataManager.curSquad.GetName() + " Stats");
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), DataManager.curSquad.GetExperience() + " XP");
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight+15, GUIManager.gridWidth, GUIManager.gridHeight), DataManager.curSquad.GetFunds() + " ZCoins");
		if (GUI.Button (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 4, GUIManager.gridWidth, GUIManager.gridHeight), "Back to World Map")) {
			GUIManager.curMode = GUIManager.Mode.World;
		}
	}
}
