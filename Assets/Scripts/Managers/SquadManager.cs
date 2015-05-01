using UnityEngine;
using System.Collections;

public static class SquadManager {
	public static ArrayList playerSquadList;
	public static void CreateNewSquad (string name, int exp, int funds){
		Squad s = new Squad ();
		s.SetName (name);
		s.SetExperience (exp);
		s.SetFunds (funds);
		playerSquadList = new ArrayList ();
		playerSquadList.Add (s);
		Debug.Log (name + " Created");
	}
}
