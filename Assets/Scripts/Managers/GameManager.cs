using UnityEngine;
using System.Collections;

public static class GameManager {

	public static void InitWorld (){
		Thevorest t = new Thevorest ();
		DataManager.mapList = new ArrayList ();
		DataManager.mapList.Add (t);
		DataManager.curMap = t;
	}

	public static void Update (){
		DataManager.curMap.HiddenTriggers ();
	}

	public static bool BattleEngine (){
		bool victory = false;
		int fudFactor = Random.Range (-2, 3);
		int squadStr = DataManager.curSquad.GetSquadStr ();
		int enemySquadStr = DataManager.curSquad.GetCurLoc ().GetHostileSquad ().GetSquadStr () + fudFactor;
		Debug.Log (squadStr + " vs " + enemySquadStr);
		if (squadStr >= enemySquadStr) {
			victory = true;
		}
		return victory;
	}
}