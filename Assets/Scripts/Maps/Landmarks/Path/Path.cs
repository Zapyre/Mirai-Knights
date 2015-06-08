using UnityEngine;
using System.Collections;

public class Path {
	protected Landmark landmark;
	protected string name;
	protected float time;

	public Path (Landmark lm, string n, float t){
		landmark = lm;
		name = n;
		time = t;
	}

	public Landmark GetLandmark (){ return landmark; }
	public void SetLandmark (Landmark lm) { landmark = lm; }
	public float GetTime (){ return time; }
	public void SetTime (float t) { time = t; }
	public string GetName () { return name; }
}