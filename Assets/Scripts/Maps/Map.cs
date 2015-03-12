using UnityEngine;
using System.Collections;

public abstract class Map {
	ArrayList landmarkList;

	public ArrayList GetLandmarkList (){ return landmarkList; }
	public void SetLandmarkList (ArrayList ll) { landmarkList = ll; }
}
