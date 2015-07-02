using UnityEngine;
using System.Collections;

public class Golem : Unit{
	public Golem (string n, Texture unitPortrait){
		name = n;
		strength = 5;
		dexterity = 2;
		intelligence = 2;
		endurance = 6;
	}
}