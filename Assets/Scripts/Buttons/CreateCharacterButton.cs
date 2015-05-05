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
	}
}