using UnityEngine;
using System.Collections;

public abstract class Unit{
	protected string name;
	protected Texture unitPortrait;
	protected Type unitType;

	protected int strength;
	protected int dexterity;
	protected int intelligence;
	protected int endurance;

	// Getters and Setters
	public Texture GetUnitPortrait () { return unitPortrait; }
	public void SetUnitPortrait (Texture up) { unitPortrait = up; }
	public Type GetUnitType () { return unitType; }
	public void SetUnitType (Type ut) { unitType = ut; }

	public int GetStrength () { return strength; }
	public void SetStrength (int s) { strength = s; }
	public int GetDexterity () { return dexterity; }
	public void SetDexterity (int d) { dexterity = d; }
	public int GetIntelligence () { return intelligence; }
	public void SetIntelligence (int i) { intelligence = i; }
	public int GetEndurance () { return endurance; }
	public void SetEndurance (int e) { endurance = e; }

	// Total Stat Calculation fields
	public int GetPhysicalDamage () {
		return unitType.GetPhysicalAttack ();
	}

	public int GetPhysicalRange () {
		return unitType.GetPhysicalRange ();
	}

	public int GetFrontBlock () {
		return unitType.GetFrontBlock ();
	}

	public int GetSideBlock () {
		return unitType.GetSideBlock ();
	}

	public int GetBackBlock () {
		return unitType.GetBackBlock ();
	}

	public int GetSpeed () {
		return unitType.GetSpeed ();
	}

	public int GetFrontDodge () {
		return unitType.GetFrontDodge ();
	}

	public int GetSideDodge () {
		return unitType.GetSideDodge ();
	}

	public int GetBackDodge () {
		return unitType.GetBackDodge ();
	}

	public int GetPhyisicalAim () {
		return unitType.GetPhyisicalAim ();
	}

	public int GetMagicAttack () {
		return unitType.GetMagicAttack ();
	}

	public int GetMagicAim () {
		return unitType.GetMagicAim ();
	}

	public int GetMagicRange () {
		return unitType.GetMagicRange ();
	}

	public int GetHealth () {
		return unitType.GetHealth ();
	}

	public int GetShield () {
		return unitType.GetShield ();
	}

	public int GetPhysicalArmor (){
		return unitType.GetPhysicalArmor ();
	}
}
