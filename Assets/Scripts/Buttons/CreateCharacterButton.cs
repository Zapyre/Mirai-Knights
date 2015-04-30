using UnityEngine;
using System.Collections;

public class CreateCharacterButton : Button{
	public CreateCharacterButton (){
		name = "Create Character";
	}
	
	public override void Action (){
		Debug.Log("Create Character");
	}
}