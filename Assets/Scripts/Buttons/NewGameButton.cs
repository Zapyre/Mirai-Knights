using UnityEngine;
using System.Collections;

public class NewGameButton : Button{
	public NewGameButton (){
		name = "New Game";
	}
	
	public override void Action (){
		CreateCharacterGui.RefreshTimer ();
		GUIManager.curMode = GUIManager.Mode.Create;
	}
}