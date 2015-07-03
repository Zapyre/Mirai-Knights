using UnityEngine;
using System.Collections;

public class Human : Unit{
	public Human (string n, Texture unitPortrait){
		name = n;
		strength = 4;
		dexterity = 3;
		intelligence = 4;
		endurance = 4;
		unitRace = "Human";
		unitType = new Novice (this);
	}
}