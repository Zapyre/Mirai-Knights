using UnityEngine;
using System.Collections;

public class Thevorest : Map {
	public Thevorest () {
		landmarkList = new ArrayList ();

		// Landmarks
		Ruins ruinedTown = new Ruins ("Ruined Town", new Vector2 (-2,-1), false, true);
		Wildlands grasslands = new Wildlands ("The Grasslands", new Vector2 (0,0), true, true);
		Wildlands wildlands = new Wildlands ("The Wildlands", new Vector2 (3,-3), true, true);
		Wildlands forest = new Wildlands ("The Forest", new Vector2 (6,0), true, true);
		Town hiddenCamp = new Town ("The Hidden Camp", new Vector2 (7, 1), false, true);
		Castle fortThevorest = new Castle ("Fort Thevorest", new Vector2 (7, -2), false, false);

		// Connections
		ArrayList pl = new ArrayList ();
		Path p1 = new Path (grasslands, "Ruined Path", 1f);
		pl.Add (p1);
		ruinedTown.SetPathList (pl);

		pl = new ArrayList ();
		Path p2 = new Path (ruinedTown, "Ruined Path", 1f);
		Path p3 = new Path (wildlands, "Path to the Wilds", 1f);
		Path p4 = new Path (forest, "Bushy Path", 1f);
		pl.Add (p2);
		pl.Add (p3);
		pl.Add (p4);
		grasslands.SetPathList (pl);

		pl = new ArrayList ();
		p2 = new Path (grasslands, "Path to the Wilds", 1f);
		p3 = new Path (fortThevorest, "Stony Path", 1f);
		p4 = new Path (forest, "Wooded Path", 1f);
		pl.Add (p2);
		pl.Add (p3);
		pl.Add (p4);
		wildlands.SetPathList (pl);

		pl = new ArrayList ();
		p2 = new Path (grasslands, "Bushy Path", 1f);
		p3 = new Path (hiddenCamp, "Hidden Path", 1f);
		p4 = new Path (wildlands, "Wooded Path", 1f);
		pl.Add (p2);
		pl.Add (p3);
		pl.Add (p4);
		forest.SetPathList (pl);

		pl = new ArrayList ();
		p2 = new Path (fortThevorest, "Back Alley", 1f);
		p3 = new Path (forest, "Hidden Path", 1f);
		pl.Add (p2);
		pl.Add (p3);
		hiddenCamp.SetPathList (pl);

		pl = new ArrayList ();
		p2 = new Path (hiddenCamp, "Back Alley", 1f);
		p3 = new Path (wildlands, "Stony Path", 1f);
		pl.Add (p2);
		pl.Add (p3);
		fortThevorest.SetPathList (pl);

		// Landmark Listing
		landmarkList.Add(ruinedTown);
		landmarkList.Add(grasslands);
		landmarkList.Add(wildlands);
		landmarkList.Add(forest);
		landmarkList.Add(hiddenCamp);
		landmarkList.Add(fortThevorest);
	}
}

