using UnityEngine;
using System.Collections;

public abstract class Button {
	protected string name;
	protected Vector2 position;
	public Button (){}
	public Button (string n){
		name = n;
	}

	public Button (string n, float x, float y){
		name = n;
		position = new Vector2 (x, y);
	}

	public abstract void Action ();

	public string GetName(){ return name; }
	public Vector2 GetPosition(){ return position; }
}