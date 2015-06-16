using UnityEngine;
using System.Collections;

public class Castle : Landmark {
	public Castle (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
	}
}

