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
}