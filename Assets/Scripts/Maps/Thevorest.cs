using UnityEngine;
using System.Collections;

public class Thevorest : Map {
	public Thevorest () {
		connectionList = new ArrayList ();
		landmarkList = new ArrayList ();

		// Landmarks
		Ruins ruinedTown = new Ruins ("Ruined Town", new Vector2 (-2,-1), true, true);
		Wildlands grasslands = new Wildlands ("The Grasslands", new Vector2 (0,0), true, true);
		Wildlands wildlands = new Wildlands ("The Wildlands", new Vector2 (3,-3), true, true);
		Wildlands forest = new Wildlands ("The Forest", new Vector2 (6,0), false, true);
		Town hiddenCamp = new Town ("The Hidden Camp", new Vector2 (7, 1), false, true);
		Castle fortThevorest = new Castle ("Fort Thevorest", new Vector2 (7, -2), false, false);

		// Connections
		ArrayList tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add (ruinedTown);
		tempLandmarkList.Add(grasslands);
		Connection con = new Connection (tempLandmarkList, "Path to the meadows", 1f);
		connectionList.Add (con);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(grasslands);
		tempLandmarkList.Add(wildlands);
		tempLandmarkList.Add(forest);
		con = new Connection (tempLandmarkList, "Forked path", 3f);
		connectionList.Add (con);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(forest);
		tempLandmarkList.Add(hiddenCamp);
		con = new Connection (tempLandmarkList, "Shadowy thicket trail", 2f);
		connectionList.Add (con);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(hiddenCamp);
		tempLandmarkList.Add(fortThevorest);
		con = new Connection (tempLandmarkList, "Secret path to the castle", 1.5f);
		connectionList.Add (con);

		tempLandmarkList = new ArrayList ();
		tempLandmarkList.Add(wildlands);
		tempLandmarkList.Add(fortThevorest);
		con = new Connection (tempLandmarkList, "Bricked path", 2.5f);
		connectionList.Add (con);

		// Landmark Listing
		landmarkList.Add(ruinedTown);
		landmarkList.Add(grasslands);
		landmarkList.Add(wildlands);
		landmarkList.Add(forest);
		landmarkList.Add(hiddenCamp);
		landmarkList.Add(fortThevorest);
	}
}

