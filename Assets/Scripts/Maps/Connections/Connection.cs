using UnityEngine;
using System.Collections;

public class Connection {
	protected ArrayList landmarkList;
	protected string name;
	protected float time;

	public Connection (ArrayList ll, string n, float t){
		landmarkList = ll;
		name = n;
		time = t;
	}

	public ArrayList GetLandmarkList (){ return landmarkList; }
	public void SetLandmarkList (ArrayList ll) { landmarkList = ll; }
	public float GetTime (){ return time; }
	public void SetTime (float t) { time = t; }
}