using UnityEngine;
using System.Collections;

public static class UnitStatusGui {
	public static void DrawGUI () {
		GUI.Label (new Rect (GUIManager.gridWidth * 4, 0, GUIManager.gridWidth, GUIManager.gridHeight), "Unit " + DataManager.curUnit.GetName());
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), "Strength: " + DataManager.curUnit.GetStrength());
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + 15, GUIManager.gridWidth, GUIManager.gridHeight), "Dexterity: " + DataManager.curUnit.GetDexterity());
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + 30, GUIManager.gridWidth, GUIManager.gridHeight), "Intelligence: " + DataManager.curUnit.GetIntelligence());
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + 45, GUIManager.gridWidth, GUIManager.gridHeight), "Endurance: " + DataManager.curUnit.GetEndurance());

		if (GUI.Button (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to Squad Status")) {
			GUIManager.curMode = GUIManager.Mode.SquadStatus;
		}
		if (GUI.Button (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to World Map")) {
			GUIManager.curMode = GUIManager.Mode.World;
		}
	}
}