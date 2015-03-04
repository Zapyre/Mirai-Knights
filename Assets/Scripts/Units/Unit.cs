using UnityEngine;
using System.Collections;

public class Unit{
	private Texture unitPortrait;
	private Type unitType;

	private int strength;
	private int dexterity;
	private int intelligence;
	private int endurance;

	public Unit (int s, int d, int i, int e){
		strength = s;
		dexterity = d;
		intelligence = i;
		endurance = e;
	}

	public void SetUnitPortrait (Texture up) { unitPortrait = up; }
	public void SetUnitType (Type ut) { unitType = ut; }

	public int GetStrength () { return strength; }
	public void SetStrength (int s) { strength = s; }
	public int GetDexterity () { return dexterity; }
	public void SetDexterity (int d) { dexterity = d; }
	public int GetIntelligence () { return intelligence; }
	public void SetIntelligence (int i) { intelligence = i; }
	public int GetEndurance () { return endurance; }
	public void SetEndurance (int e) { endurance = e; }


}
