using UnityEngine;
using System.Collections;

public abstract class Unit {
	protected string name;
	protected Texture unitPortrait;
	protected Type unitType;
	protected ArrayList weaponList;
	protected ArrayList armorList;

	protected int strength;
	protected int dexterity;
	protected int intelligence;
	protected int endurance;

	protected int curHP;
	protected int curShield;
	protected int curAP;
	protected int curDir;
	protected Vector3 curPos;

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

	public int GetCurHP () { return curHP; }
	public void SetCurHP (int chp) { curHP = chp; }
	public int GetCurShield () { return curShield; }
	public void SetCurShield (int chp) { curShield = chp; }
	public int GetCurAP () { return curAP; }
	public void SetCurAP (int cap) { curAP = cap; }
	public int GetCurDir () { return curDir; }
	public void SetCurDir (int cd) { curDir = cd; }
	public Vector3 GetCurPos () { return curPos; }
	public void SetCurPos (Vector3 cp) { curPos = cp; }

	// Total Stat Calculation fields
	public int GetPhysicalDamage () {
		int totalPhysicalDamage = unitType.GetPhysicalAttack ();
		foreach (Weapon weapon in weaponList) {
			totalPhysicalDamage += weapon.GetPhysicalAttack ();
		}
		foreach (Armor armor in armorList) {
			totalPhysicalDamage += armor.GetPhysicalAttack ();
		}
		return totalPhysicalDamage;
	}

	public int GetPhysicalRange () {
		bool ranged = false;
		int maxRange = 0;
		foreach (Weapon weapon in weaponList) {
			// Check if weapon is ranged
			if (weapon.GetWeaponType() == (int)Weapon.WeaponType.Ranged) {
				ranged = true;
			}
			// Get max ranged weapon
			if (weapon.GetPhysicalRange() > maxRange) {
				maxRange = weapon.GetPhysicalRange();
			}
		}
		if (ranged) {
			maxRange += unitType.GetPhysicalRange ();
			foreach (Armor armor in armorList) {
				maxRange += armor.GetPhysicalRange ();
			}
		}
		return maxRange;
	}

	public int GetFrontBlock () {
		int totalFrontBlock = unitType.GetFrontBlock ();
		foreach (Weapon weapon in weaponList) {
			totalFrontBlock += weapon.GetFrontBlock ();
		}
		foreach (Armor armor in armorList) {
			totalFrontBlock += armor.GetFrontBlock ();
		}
		return totalFrontBlock;
	}

	public int GetSideBlock () {
		int totalSideBlock = unitType.GetSideBlock ();
		foreach (Weapon weapon in weaponList) {
			totalSideBlock += weapon.GetSideBlock ();
		}
		foreach (Armor armor in armorList) {
			totalSideBlock += armor.GetSideBlock ();
		}
		return totalSideBlock;
	}

	public int GetBackBlock () {
		int totalBackBlock = unitType.GetBackBlock ();
		foreach (Weapon weapon in weaponList) {
			totalBackBlock += weapon.GetBackBlock ();
		}
		foreach (Armor armor in armorList) {
			totalBackBlock += armor.GetBackBlock ();
		}
		return totalBackBlock;
	}

	public int GetSpeed () {
		int totalSpeed = unitType.GetSpeed ();
		foreach (Weapon weapon in weaponList) {
			totalSpeed += weapon.GetSpeed ();
		}
		foreach (Armor armor in armorList) {
			totalSpeed += armor.GetSpeed ();
		}
		return totalSpeed;
	}

	public int GetFrontDodge () {
		int totalFrontDodge = unitType.GetFrontDodge ();
		foreach (Weapon weapon in weaponList) {
			totalFrontDodge += weapon.GetFrontDodge ();
		}
		foreach (Armor armor in armorList) {
			totalFrontDodge += armor.GetFrontDodge ();
		}
		return totalFrontDodge;
	}

	public int GetSideDodge () {
		int totalSideDodge = unitType.GetSideDodge ();
		foreach (Weapon weapon in weaponList) {
			totalSideDodge += weapon.GetSideDodge ();
		}
		foreach (Armor armor in armorList) {
			totalSideDodge += armor.GetSideDodge ();
		}
		return totalSideDodge;
	}

	public int GetBackDodge () {
		int totalBackDodge = unitType.GetBackDodge ();
		foreach (Weapon weapon in weaponList) {
			totalBackDodge += weapon.GetBackDodge ();
		}
		foreach (Armor armor in armorList) {
			totalBackDodge += armor.GetBackDodge ();
		}
		return totalBackDodge;
	}

	public int GetPhyisicalAim () {
		int totalPhysicalAim = unitType.GetPhyisicalAim ();
		foreach (Weapon weapon in weaponList) {
			totalPhysicalAim += weapon.GetPhyisicalAim ();
		}
		foreach (Armor armor in armorList) {
			totalPhysicalAim += armor.GetPhyisicalAim ();
		}
		return totalPhysicalAim;
	}

	public int GetMagicDamage () {
		int totalMagicDamage = unitType.GetMagicAttack ();
		foreach (Weapon weapon in weaponList) {
			totalMagicDamage += weapon.GetMagicAttack ();
		}
		foreach (Armor armor in armorList) {
			totalMagicDamage += armor.GetMagicAttack ();
		}
		return totalMagicDamage;
	}

	public int GetMagicAim () {
		int totalMagicAim = unitType.GetMagicAim ();
		foreach (Weapon weapon in weaponList) {
			totalMagicAim += weapon.GetMagicAim ();
		}
		foreach (Armor armor in armorList) {
			totalMagicAim += armor.GetMagicAim ();
		}
		return totalMagicAim;
	}

	public int GetMagicRange () {
		int maxRange = 0;
		foreach (Weapon weapon in weaponList) {
			if (weapon.GetMagicRange() > maxRange){
				maxRange = weapon.GetMagicRange();
			}
		}
		maxRange += unitType.GetMagicRange ();
		foreach (Armor armor in armorList) {
			maxRange += armor.GetMagicRange ();
		}
		return maxRange;
	}

	public int GetHealth () {
		int totalHealth = unitType.GetHealth ();
		foreach (Weapon weapon in weaponList) {
			totalHealth += weapon.GetHealth ();
		}
		foreach (Armor armor in armorList) {
			totalHealth += armor.GetHealth ();
		}
		return totalHealth;
	}

	public int GetShield () {
		int totalShield = unitType.GetShield ();
		foreach (Weapon weapon in weaponList) {
			totalShield += weapon.GetShield ();
		}
		foreach (Armor armor in armorList) {
			totalShield += armor.GetShield ();
		}
		return totalShield;
	}

	public int GetActionPoints () {
		int totalActionPoints = unitType.GetActionPoints ();
		foreach (Weapon weapon in weaponList) {
			totalActionPoints += weapon.GetActionPoints ();
		}
		foreach (Armor armor in armorList) {
			totalActionPoints += armor.GetActionPoints ();
		}
		return totalActionPoints;
	}

	public int GetJump () {
		int totalJump = unitType.GetJump ();
		foreach (Weapon weapon in weaponList) {
			totalJump += weapon.GetJump ();
		}
		foreach (Armor armor in armorList) {
			totalJump += armor.GetJump ();
		}
		return totalJump;
	}

	public int GetPhysicalArmor () {
		int totalPhysicalArmor = unitType.GetPhysicalArmor ();
		foreach (Weapon weapon in weaponList) {
			totalPhysicalArmor += weapon.GetPhysicalArmor ();
		}
		foreach (Armor armor in armorList) {
			totalPhysicalArmor += armor.GetPhysicalArmor ();
		}
		return totalPhysicalArmor;
	}

	public int GetMagicArmor () {
		int totalMagicArmor = unitType.GetMagicArmor ();
		foreach (Weapon weapon in weaponList) {
			totalMagicArmor += weapon.GetMagicArmor ();
		}
		foreach (Armor armor in armorList) {
			totalMagicArmor += armor.GetMagicArmor ();
		}
		return totalMagicArmor;
	}
}
