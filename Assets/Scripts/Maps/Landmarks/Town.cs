using UnityEngine;
using System.Collections;

public class Town : Landmark {
	public Town (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
	}

	// AutoMenu 
	public override void AutoMenu (){
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new TownMenu ();
		}
	}
}
