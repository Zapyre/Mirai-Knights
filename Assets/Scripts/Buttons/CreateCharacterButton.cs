using UnityEngine;
using System.Collections;

public class CreateCharacterButton : Button{
	public CreateCharacterButton (){
		name = "Create Squad and Character";
	}
	
	public override void Action (){
		Human u = new Human (CreateCharacterGui.charName, null);
		SquadManager.CreateNewSquad (u, CreateCharacterGui.squadName, 0, 0);
		GUIManager.curMode = GUIManager.Mode.World;

		Human u2 = new Human ("Xyla", null);
		Protonoid u3 = new Protonoid ("Xantech", null);
		Golem u4 = new Golem ("Ro", null);
		ArrayList unitList = DataManager.curSquad.GetUnitList ();
		unitList.Add (u2);
		unitList.Add (u3);
		unitList.Add (u4);
	}
}