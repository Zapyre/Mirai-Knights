using UnityEngine;
using System.Collections;

public static class SquadManager {
	public static void InitSquadManager(){
		DataManager.playerSquadList = new ArrayList ();
	}

	public static void CreateNewSquad (Unit u, string name, int exp, int funds){
		Squad s = new Squad ();
		s.SetName (name);
		s.SetExperience (exp);
		s.SetFunds (funds);
		s.SetLeader (u);
		s.AddUnit (u);
		s.SetCurLoc ((Landmark)(DataManager.curMap.GetLandmarkList()[0]));
		DataManager.curSquad = s;
		DataManager.playerSquadList.Add (s);
	}

	public static void MoveSquad (Landmark lm){
		DataManager.curSquad.SetCurLoc (lm);
	}
}
