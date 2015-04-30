using UnityEngine;
using System.Collections;

public class NewGameButton : Button{
	public NewGameButton (){
		name = "New Game";
	}
	
	public override void Action (){
		CreateCharacterGui.InitGUI ();
		GUIManager.curMode = GUIManager.Mode.Create;
	}
}