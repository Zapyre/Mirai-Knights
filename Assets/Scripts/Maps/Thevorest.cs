using UnityEngine;
using System.Collections;

public class Thevorest : Map {
	public Thevorest (){
		connectionList = new ArrayList ();
		landmarkList = new ArrayList ();

		// Landmarks
		Ruins ruinedTown = new Ruins ("Ruined Town", new Vector2 (-2,-1), true);
		Wildlands grasslands = new Wildlands ("The Grasslands", new Vector2 (0,0), true);
		Wildlands wildlands = new Wildlands ("The Wildlands", new Vector2 (3,-3), true);
		Wildlands forest = new Wildlands ("The Forest", new Vector2 (6,0), false);
		Town hiddenCamp = new Town ("The Hidden Camp", new Vector2 (7, 1), false);

		// Connections
		ArrayList tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add (ruinedTown);
		tempLandmarkList.Add(grasslands);
		Connection con = new Connection (tempLandmarkList, "Trail to the meadows");
		connectionList.Add (con);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(grasslands);
		tempLandmarkList.Add(wildlands);
		tempLandmarkList.Add(forest);
		con = new Connection (tempLandmarkList, "Forked path");
		connectionList.Add (con);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(forest);
		tempLandmarkList.Add(hiddenCamp);
		con = new Connection (tempLandmarkList, "Road to camp");
		connectionList.Add (con);

		// Landmark Listing
		landmarkList.Add(ruinedTown);
		landmarkList.Add(grasslands);
		landmarkList.Add(wildlands);
		landmarkList.Add(forest);
		landmarkList.Add(hiddenCamp);

	}
}

