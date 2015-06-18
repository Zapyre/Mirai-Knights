using UnityEngine;
using System.Collections;

public class Castle : Landmark {
	public Castle (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
		hostileRating = 1;
	}

	public Castle (string n, Vector2 pos, bool h, bool show, int hr){
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
			menu = new CastleMenu ();
		}
	}
}

