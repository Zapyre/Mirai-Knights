using UnityEngine;
using System.Collections;

public class Castle : Landmark {
	public Castle (string n, Vector2 pos, bool hostile, bool show){
		name = n;
		position = pos;
		if (hostile) {
			menu = new HostileMenu ();
		} else {
			menu = new CastleMenu ();
		}
		shown = show;
	}
}

