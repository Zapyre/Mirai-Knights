using UnityEngine;
using System.Collections;

public static class SquadStatusGui {
	public static void DrawGUI () {
		GUI.Label (new Rect (GUIManager.gridWidth * 4, 0, GUIManager.gridWidth, GUIManager.gridHeight), "Squad " + DataManager.curSquad.GetName() + " Stats");
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), DataManager.curSquad.GetExperience() + " XP");
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight+15, GUIManager.gridWidth, GUIManager.gridHeight), DataManager.curSquad.GetFunds() + " ZCoins");

		ArrayList unitList = DataManager.curSquad.GetUnitList ();
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight*3, GUIManager.gridWidth, GUIManager.gridHeight), "Squad Members " + unitList.Count + "/4");

		for (int i = 0; i < unitList.Count; i++){
			if (GUI.Button (new Rect (GUIManager.gridWidth * (2 * (i + 1) - 1), GUIManager.gridHeight*4, GUIManager.gridWidth, GUIManager.gridHeight), ((Unit)unitList[i]).GetName())){
				DataManager.curUnit = (Unit)unitList[i];
				GUIManager.curMode = GUIManager.Mode.UnitStatus;
			}
		}

		if (GUI.Button (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to World Map")) {
			GUIManager.curMode = GUIManager.Mode.World;
		}
	}
}
