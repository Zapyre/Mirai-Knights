using UnityEngine;
using System.Collections;

public class LandmarkButton : Button{
	Landmark landmark;
	public LandmarkButton (){
		name = "Landmark";
	}

	public LandmarkButton (Landmark lm){
		landmark = lm;
		position = lm.GetPosition ();
		name = lm.GetName ();
	}
	
	public override void Action (){
		Debug.Log ("Landmark " + name + " Clicked!");
		WorldMapGui.curLandmark = landmark;
		if (SquadManager.curSquad.GetCurLoc ().GetName () == landmark.GetName()) {
			WorldMapGui.curLandmark = null;
		}
	}
}
