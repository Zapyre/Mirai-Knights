using UnityEngine;
using System.Collections;

public class Thevorest : Map {
	public Thevorest (){
		connectionList = new ArrayList ();

		landmarkList = new ArrayList ();
		Wildlands grasslands = new Wildlands ("The Grasslands", new Vector2 (0,0), true);
		Wildlands wildlands = new Wildlands ("The Wildlands", new Vector2 (3,0), true);
		Wildlands forest = new Wildlands ("The Forest", new Vector2 (6,0), false);

		ArrayList tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(grasslands);
		tempLandmarkList.Add(wildlands);
		tempLandmarkList.Add(forest);
		Connection con = new Connection (tempLandmarkList, "Forked path");
		connectionList.Add (con);

		Town hiddenCamp = new Town ("The Hidden Camp", new Vector2 (7, 1), false);
		landmarkList.Add(grasslands);
		landmarkList.Add(wildlands);
		landmarkList.Add(forest);
		landmarkList.Add(hiddenCamp);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(hiddenCamp);
		con = new Connection (tempLandmarkList, "Road to camp");
		connectionList.Add (con);
	}
}

