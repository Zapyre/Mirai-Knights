using UnityEngine;
using System.Collections;

public static class SquadStatusGui {
	public static void DrawGUI () {

		GUIStyle gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleCenter;
		gsTitle.normal.textColor = Color.green;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;

		GUI.Label (new Rect (GUIManager.gridWidth * 4, 0, GUIManager.gridWidth, GUIManager.gridHeight), "<b>Squad " + DataManager.curSquad.GetName() + " Stats</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), DataManager.curSquad.GetExperience() + " XP");
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + GUIManager.gridHeight/5, GUIManager.gridWidth, GUIManager.gridHeight), DataManager.curSquad.GetFunds() + " ZCoins");

		ArrayList unitList = DataManager.curSquad.GetUnitList ();
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight*2, GUIManager.gridWidth, GUIManager.gridHeight), "Squad Members " + unitList.Count + "/8");

		for (int i = 0; i < 4; i++){
			if (i < unitList.Count){
				if (GUI.Button (new Rect (GUIManager.gridWidth * (2 * (i + 1) - 1), GUIManager.gridHeight*3, GUIManager.gridWidth, GUIManager.gridHeight), ((Unit)unitList[i]).GetName())){
					DataManager.curUnit = (Unit)unitList[i];
					GUIManager.curMode = GUIManager.Mode.UnitStatus;
				}
			}
			else {
				if (GUI.Button (new Rect (GUIManager.gridWidth * (2 * (i + 1) - 1), GUIManager.gridHeight*3, GUIManager.gridWidth, GUIManager.gridHeight), "Empty")){
					GUIManager.curMode = GUIManager.Mode.Recruitment;
				}
			}
		}

		for (int i = 0; i < 4; i++){
			if (i + 4 < unitList.Count){
				if (GUI.Button (new Rect (GUIManager.gridWidth * (2 * (i + 1) - 1), GUIManager.gridHeight * 5, GUIManager.gridWidth, GUIManager.gridHeight), ((Unit)unitList[i + 4]).GetName())){
					DataManager.curUnit = (Unit)unitList[i + 4];
					GUIManager.curMode = GUIManager.Mode.UnitStatus;
				}
			}
			else {
				if (GUI.Button (new Rect (GUIManager.gridWidth * (2 * (i + 1) - 1), GUIManager.gridHeight * 5, GUIManager.gridWidth, GUIManager.gridHeight), "Empty")){
					GUIManager.curMode = GUIManager.Mode.Recruitment;
				}
			}
		}

		if (GUI.Button (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to World Map")) {
			GUIManager.curMode = GUIManager.Mode.World;
		}
	}
}
