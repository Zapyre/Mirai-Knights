using UnityEngine;
using System.Collections;

public abstract class Map {
	protected ArrayList landmarkList;

	public ArrayList GetLandmarkList (){ return landmarkList; }
	public void SetLandmarkList (ArrayList ll) { landmarkList = ll; }

	public ArrayList GetShortestPath (Landmark pointA, Landmark pointB){
		ArrayList sp = new ArrayList ();
		return sp;
	}
}
