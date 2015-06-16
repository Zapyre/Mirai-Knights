using UnityEngine;
using System.Collections;

public class Ruins : Landmark {
	public Ruins (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
	}
}

