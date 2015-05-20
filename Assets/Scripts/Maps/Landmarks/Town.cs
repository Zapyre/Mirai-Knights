using UnityEngine;
using System.Collections;

public class Town : Landmark {
	public Town (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new TownMenu ();
		}
		shown = show;
	}
}
