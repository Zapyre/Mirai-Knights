using UnityEngine;
using System.Collections;

public class Connection {
	protected ArrayList landmarkList;
	protected string name;

	public Connection (ArrayList ll, string n){
		landmarkList = ll;
		name = n;
	}

	public ArrayList GetLandmarkList (){ return landmarkList; }
	public void SetLandmarkList (ArrayList ll) { landmarkList = ll; }
}