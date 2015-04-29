using UnityEngine;
using System.Collections;

public class ContinueButton : Button{
	public ContinueButton (){
		name = "Continue Game";
	}
	
	public override void Action (){
		Debug.Log("Continue Pressed");
	}
}