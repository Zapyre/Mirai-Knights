using UnityEngine;
using System.Collections;

public class Golem : Unit{
	public Golem (string name, Texture unitPortrait, UnitType unitType){
		strength = 5;
		dexterity = 2;
		intelligence = 2;
		endurance = 6;
	}
}