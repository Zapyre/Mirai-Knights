using UnityEngine;
using System.Collections;

public class Wildlands : Landmark {
	public Wildlands (Vector2 pos, ArrayList landmarkList){
		name = "The Wildlands";
		position = pos;
		landmarkConnectionList = landmarkList;
		menu = new WildlandsMenu ();
	}
}
