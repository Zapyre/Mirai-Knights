using UnityEngine;
using System.Collections;

public class CreateCharacterButton : Button{
	public CreateCharacterButton (){
		name = "Create Squad and Character";
	}
	
	public override void Action (){
		SquadManager.CreateNewSquad (CreateCharacterGui.squadName, 0, 0);
	}
}