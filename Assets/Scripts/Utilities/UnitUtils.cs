using UnityEngine;
using System.Collections;

public static class UnitUtils {
	public static int DirectionCalc (Unit attacker, Unit defender) {
		int direction = 0;
		Vector3 aPos = attacker.GetCurPos ();
		Vector3 dPos = defender.GetCurPos ();
		if (aPos.y - dPos.y > 0 && Mathf.Abs (aPos.x - dPos.x) < Mathf.Abs (aPos.y - dPos.y)) { 
			if (defender.GetCurDir() == 8){
				direction = (int)Attack.Direction.Front;
			}
			else if (defender.GetCurDir () == 2) {
				direction = (int)Attack.Direction.Back;
			}
			else {
				direction = (int)Attack.Direction.Side;
			}
		}
		else if (aPos.y - dPos.y < 0 && Mathf.Abs (aPos.x - dPos.x) < Mathf.Abs (aPos.y - dPos.y)){
			if (defender.GetCurDir() == 2){
				direction = (int)Attack.Direction.Front;
			}
			else if (defender.GetCurDir () == 8) {
				direction = (int)Attack.Direction.Back;
			}
			else {
				direction = (int)Attack.Direction.Side;
			}
		}
		else if (aPos.x - dPos.x > 0 && Mathf.Abs (aPos.y - dPos.y) < Mathf.Abs (aPos.x - dPos.x)){
			if (defender.GetCurDir() == 6){
				direction = (int)Attack.Direction.Front;
			}
			else if (defender.GetCurDir () == 4) {
				direction = (int)Attack.Direction.Back;
			}
			else {
				direction = (int)Attack.Direction.Side;
			}
		}
		else if (aPos.x - dPos.x < 0 && Mathf.Abs (aPos.y - dPos.y) < Mathf.Abs (aPos.x - dPos.x)){
			if (defender.GetCurDir() == 4){
				direction = (int)Attack.Direction.Front;
			}
			else if (defender.GetCurDir () == 6) {
				direction = (int)Attack.Direction.Back;
			}
			else {
				direction = (int)Attack.Direction.Side;
			}
		}
		else {
			direction = (int)Attack.Direction.Back;
		}

		return direction;
	}

	public static int UnitLevelCalc (int exp) {
		int [] levelCap = new int [10];
		levelCap [0] = 1000;
		levelCap [1] = 5000;
		levelCap [2] = 10000;
		levelCap [3] = 20000;
		levelCap [4] = 30000;
		levelCap [5] = 50000;
		levelCap [6] = 75000;
		levelCap [7] = 100000;
		levelCap [8] = 150000;
		levelCap [9] = 250000;

		int level = 10;
		for (int i = 0; i < levelCap.Length; i++) {
			if (exp < levelCap[i]){
				level = i;
				break;
			}
		}

		return level;
	}
}
