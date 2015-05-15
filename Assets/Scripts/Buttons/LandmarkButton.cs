using UnityEngine;
using System.Collections;

public class LandmarkButton : Button{
	Landmark landmark;
	public LandmarkButton (){
		name = "Landmark";
	}

	public LandmarkButton (string n, float x, float y){
		name = n;
		position = new Vector2 (x, y);
	}

	public LandmarkButton (Landmark lm){
		landmark = lm;
		position = lm.GetPosition ();
	}
	
	public override void Action (){
		Debug.Log ("Landmark " + name + " Clicked!");
	}
}
