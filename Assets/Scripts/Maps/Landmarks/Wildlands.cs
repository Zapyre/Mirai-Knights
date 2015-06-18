using UnityEngine;
using System.Collections;

public class Wildlands : Landmark {
	public Wildlands (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
		hostileRating = 1;
	}

	public Wildlands (string n, Vector2 pos, bool h, bool show, int hr){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
		hostileRating = hr;
	}

	// AutoMenu 
	public override void AutoMenu (){
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new WildlandsMenu ();
		}
	}
}
