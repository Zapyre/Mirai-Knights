using UnityEngine;
using System.Collections;

public class NewGameButton : Button{
	public NewGameButton (){
		name = "New Game";
	}
	
	public override void Action (){
		Debug.Log("New Game Pressed");
	}
}