using UnityEngine;
using System.Collections;

public class Town : Landmark {
	public Town (string n, Vector2 pos, bool hostile){
		name = n;
		position = pos;
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new TownMenu ();
		}
	}
}
