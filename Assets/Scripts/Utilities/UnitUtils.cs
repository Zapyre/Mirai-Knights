using UnityEngine;
using System.Collections;

public static class UnitUtils {
	public static int DirectionCalc (Unit attacker, Unit defender){
		Vector3 aPos = attacker.GetCurPos ();
		Vector3 dPos = defender.GetCurPos ();
		return (int) Attack.Direction.Front;
	}
}
