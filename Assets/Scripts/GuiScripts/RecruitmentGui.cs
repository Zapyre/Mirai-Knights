using UnityEngine;
using System.Collections;

public static class RecruitmentGui {
	public static void DrawGUI () {
		GUIStyle gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleCenter;
		gsTitle.normal.textColor = Color.magenta;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;
		
		GUI.Label (new Rect (GUIManager.gridWidth * 4, 0, GUIManager.gridWidth, GUIManager.gridHeight), "<b>Squad Recruitment</b>", gsTitle);

		gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleLeft;
		gsTitle.normal.textColor = Color.green;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;

		ArrayList unitList = DataManager.curSquad.GetUnitList ();
		GUI.Label (new Rect (GUIManager.gridWidth * 2, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), "<b>Squad Members " + unitList.Count + "/8</b>", gsTitle);

		gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleLeft;
		gsTitle.normal.textColor = Color.red;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;
		GUI.Label (new Rect (GUIManager.gridWidth * 6, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), "<b>Recruitment List</b>", gsTitle);

		GUIStyle gs = new GUIStyle ();
		gs.alignment = TextAnchor.MiddleLeft;
		gs.normal.textColor = Color.white;


		if (GUI.Button (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to Squad Status")) {
			GUIManager.curMode = GUIManager.Mode.SquadStatus;
		}
		if (GUI.Button (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to World Map")) {
			GUIManager.curMode = GUIManager.Mode.World;
		}
	}
}