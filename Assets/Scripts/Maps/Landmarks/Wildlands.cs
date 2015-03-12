using UnityEngine;
using System.Collections;

public class Wildlands : Landmark {
	public Wildlands (string n, Vector2 pos, ArrayList landmarkList){
		name = n;
		position = pos;
		menu = new WildlandsMenu ();
	}
}
