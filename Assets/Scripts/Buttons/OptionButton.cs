using UnityEngine;
using System.Collections;

public class OptionButton : Button{
	public OptionButton (){
		name = "Options";
	}
	
	public override void Action (){
		Debug.Log("Options Pressed");
	}
}