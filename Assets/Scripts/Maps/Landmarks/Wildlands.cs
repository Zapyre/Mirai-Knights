using UnityEngine;
using System.Collections;

public class Wildlands : Landmark {
	public Wildlands (string n, Vector2 pos, bool h, bool show){
		name = n;
		position = pos;
		hostile = h;
		shown = show;
		AutoMenu ();
	}
}
