using UnityEngine;
using System.Collections;

public abstract class Button {
	protected string name;
	public Button (){}
	public Button (string n){
		name = n;
	}

	public abstract void Action ();

	public string GetName(){ return name; }
}