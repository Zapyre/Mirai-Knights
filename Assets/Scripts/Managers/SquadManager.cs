using UnityEngine;
using System.Collections;

public static class SquadManager {
	private static float maxTime;
	private static ArrayList quickestPath;
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
		// Adding interm movement
		Landmark curLm = DataManager.curSquad.GetCurLoc ();
		maxTime = 99;
		quickestPath = new ArrayList ();
		FindQuickestPath (curLm, lm, new ArrayList (), 0);
		/*string cityList = "";
		foreach (Landmark sololm in quickestPath){
			cityList += ", " + sololm.GetName();
		}
		Debug.Log (cityList);
		Debug.Log (maxTime);*/

		bool blocked = false;
		foreach (Landmark sololm in quickestPath){
			if (sololm.IsHostile()){
				int rdmNum = Random.Range (0,sololm.GetHostileRating());
				if (rdmNum == 0){
					DataManager.curSquad.SetCurLoc (sololm);
					Debug.Log ("You have been blocked at " + sololm.GetName());
					blocked = true;
					break;
				}
			}
		}
		if (!blocked) {
			Debug.Log ("You have arrived at " + lm.GetName());
			DataManager.curSquad.SetCurLoc (lm);
		}
	}

	private static void FindQuickestPath (Landmark start, Landmark end, ArrayList path, float time){
		if (start.Equals(end)) {
			path.Add (start);
			if (time < maxTime){
				quickestPath = path;
				maxTime = time;
			}
			return;
		}
		else if (time > maxTime){
			return;
		}
		else {
			ArrayList pathList = start.GetPathList ();
			ArrayList route = new ArrayList ();
			foreach (Landmark lm in path){
				route.Add (lm);
			}
			route.Add(start);
			foreach (Path p in pathList){
				if (!path.Contains(p.GetLandmark()) && DataManager.curMap.GetVisibleLandmarkList().Contains(p.GetLandmark ())){
					FindQuickestPath(p.GetLandmark(), end, route, (time + p.GetTime()));
				}
			}
		}
	}
}
