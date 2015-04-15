using UnityEngine;
using System.Collections;

public class Wildlands : Landmark {
	public Wildlands (string n, Vector2 pos, bool hostile, bool show){
		name = n;
		position = pos;
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new WildlandsMenu ();
		}
		shown = show;
	}
}
