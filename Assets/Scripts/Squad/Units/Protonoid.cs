using UnityEngine;
using System.Collections;

public class Protonoid : Unit{
	public Protonoid (string n, Texture unitPortrait){
		name = n;
		strength = 2;
		dexterity = 3;
		intelligence = 5;
		endurance = 5;
		unitRace = "Protonoid";
		unitType = new Novice (this);
	}
}