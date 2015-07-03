using UnityEngine;
using System.Collections;

public static class UnitStatusGui {
	public static void DrawGUI () {
		GUIStyle gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleCenter;
		gsTitle.normal.textColor = Color.green;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;

		GUI.Label (new Rect (GUIManager.gridWidth * 4, 0, GUIManager.gridWidth, GUIManager.gridHeight), "<b>" + DataManager.curUnit.GetUnitType().GetName() + " " + DataManager.curUnit.GetName() + "</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight/5, GUIManager.gridWidth, GUIManager.gridHeight), "Race: " + DataManager.curUnit.GetUnitRace());
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight*2/5, GUIManager.gridWidth, GUIManager.gridHeight), "Action Points: " + DataManager.curUnit.GetUnitType().GetActionPoints());

		gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleCenter;
		gsTitle.normal.textColor = Color.red;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;
		
		GUIStyle gs = new GUIStyle ();
		gs.alignment = TextAnchor.MiddleCenter;
		gs.normal.textColor = Color.white;

		// Primary Stats
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight, GUIManager.gridWidth, GUIManager.gridHeight), "<b>Primary Statistics</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + GUIManager.gridHeight/5, GUIManager.gridWidth, GUIManager.gridHeight), "Strength: " + DataManager.curUnit.GetStrength(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + GUIManager.gridHeight*2/5, GUIManager.gridWidth, GUIManager.gridHeight), "Dexterity: " + DataManager.curUnit.GetDexterity(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + GUIManager.gridHeight*3/5, GUIManager.gridWidth, GUIManager.gridHeight), "Intelligence: " + DataManager.curUnit.GetIntelligence(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight + GUIManager.gridHeight*4/5, GUIManager.gridWidth, GUIManager.gridHeight), "Endurance: " + DataManager.curUnit.GetEndurance(), gs);

		gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleLeft;
		gsTitle.normal.textColor = Color.yellow;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;

		gs = new GUIStyle ();
		gs.alignment = TextAnchor.MiddleLeft;
		gs.normal.textColor = Color.white;

		// Secondary Stats (Str)
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 2 + GUIManager.gridHeight/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "<b>Strength Attributes</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 2 + GUIManager.gridHeight*2/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Physical Attack Bonus: " + DataManager.curUnit.GetUnitType().GetPhysicalAttack(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 2 + GUIManager.gridHeight*3/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Physical Range Bonus: " + DataManager.curUnit.GetUnitType().GetPhysicalRange(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 2 + GUIManager.gridHeight*4/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Block % (Front/Side/Back): (" + DataManager.curUnit.GetUnitType().GetBlock((int)Attack.Direction.Front) + "%/" + DataManager.curUnit.GetUnitType().GetBlock((int)Attack.Direction.Side) + "%/" + DataManager.curUnit.GetUnitType().GetBlock((int)Attack.Direction.Back) + "%)", gs);

		// Secondary Stats (Int)
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 2 + GUIManager.gridHeight/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "<b>Intelligence Attributes</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 2 + GUIManager.gridHeight*2/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Magic Attack Bonus: " + DataManager.curUnit.GetUnitType().GetMagicAttack(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 2 + GUIManager.gridHeight*3/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Magic Aim: " + DataManager.curUnit.GetUnitType().GetMagicAim() + "%", gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 2 + GUIManager.gridHeight*4/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Magic Range Bonus: " + DataManager.curUnit.GetUnitType().GetMagicRange(), gs);

		// Secondary Stats (Dex)
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 3 + GUIManager.gridHeight/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "<b>Dexterity Attributes</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 3 + GUIManager.gridHeight*2/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Speed: " + DataManager.curUnit.GetUnitType().GetSpeed(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 3 + GUIManager.gridHeight*3/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Phyisical Aim: " + DataManager.curUnit.GetUnitType().GetPhysicalAim() + "%", gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 3 + GUIManager.gridHeight*4/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Dodge % (Front/Side/Back): (" + DataManager.curUnit.GetUnitType().GetDodge((int)Attack.Direction.Front) + "%/" + DataManager.curUnit.GetUnitType().GetDodge((int)Attack.Direction.Side) + "%/" + DataManager.curUnit.GetUnitType().GetDodge((int)Attack.Direction.Back) + "%)", gs);

		// Secondary Stats (End)
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 3 + GUIManager.gridHeight/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "<b>Endurance Attributes</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 3 + GUIManager.gridHeight*2/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Health: " + DataManager.curUnit.GetUnitType().GetHealth(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 3 + GUIManager.gridHeight*3/5, GUIManager.gridWidth*2, GUIManager.gridHeight), "Shield: " + DataManager.curUnit.GetUnitType().GetShield(), gs);

		gsTitle = new GUIStyle ();
		gsTitle.alignment = TextAnchor.MiddleCenter;
		gsTitle.normal.textColor = Color.yellow;
		gsTitle.fontSize = 15;
		gsTitle.richText = true;
		
		gs = new GUIStyle ();
		gs.alignment = TextAnchor.MiddleCenter;
		gs.normal.textColor = Color.white;

		// Secondary Stats (Mixed)
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 4 + GUIManager.gridHeight/5, GUIManager.gridWidth, GUIManager.gridHeight), "<b>Mixed Attributes</b>", gsTitle);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 4 + GUIManager.gridHeight*2/5, GUIManager.gridWidth, GUIManager.gridHeight), "Jump: " + DataManager.curUnit.GetUnitType().GetJump(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 4 + GUIManager.gridHeight*3/5, GUIManager.gridWidth, GUIManager.gridHeight), "Physical Armor: " + DataManager.curUnit.GetUnitType().GetPhysicalArmor(), gs);
		GUI.Label (new Rect (GUIManager.gridWidth * 4, GUIManager.gridHeight * 4 + GUIManager.gridHeight*4/5, GUIManager.gridWidth, GUIManager.gridHeight), "Magic Armor: " + DataManager.curUnit.GetUnitType().GetMagicArmor(), gs);

		if (GUI.Button (new Rect (GUIManager.gridWidth * 3, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to Squad Status")) {
			GUIManager.curMode = GUIManager.Mode.SquadStatus;
		}
		if (GUI.Button (new Rect (GUIManager.gridWidth * 5, GUIManager.gridHeight * 8, GUIManager.gridWidth, GUIManager.gridHeight), "Back to World Map")) {
			GUIManager.curMode = GUIManager.Mode.World;
		}
	}
}