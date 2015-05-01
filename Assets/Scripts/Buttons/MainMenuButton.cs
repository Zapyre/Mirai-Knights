using UnityEngine;
using System.Collections;

public class MainMenuButton : Button{
	public MainMenuButton (){
		name = "Back to Main Menu";
	}
	
	public override void Action (){
		GUIManager.curMode = GUIManager.Mode.Main;
		MainMenuGui.RefreshTimer ();
	}
}
