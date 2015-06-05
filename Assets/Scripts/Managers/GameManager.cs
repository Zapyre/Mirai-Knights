using UnityEngine;
using System.Collections;

public static class GameManager {
	public static Map curMap;
	public static ArrayList mapList;
	public static void InitWorld (){
		Thevorest t = new Thevorest ();
		mapList = new ArrayList ();
		mapList.Add (t);
		curMap = t;
	}

	public static void MoveSquad (){
	}
}