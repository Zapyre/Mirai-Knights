using UnityEngine;
using System.Collections;
public class BasicPhysicalAttack : Attack {
	protected string damageCalcString;
	protected string rangeCalcString;
	protected string aimCalcString;
	protected int damage;
	protected int range;
	protected int aim;

	public BasicPhysicalAttack (Unit attacker) {
		unitAtk = attacker;
		damage = attacker.GetPhysicalDamage ();
		range = attacker.GetPhysicalRange ();
		aim = attacker.GetPhyisicalAim ();
		damageCalcString = "Damage: " + damage;
		rangeCalcString = "Range: " + range;
		aimCalcString = "Aim: " + aim;
	}

	public void SetDefender (Unit defender) {
		damageCalcString += " - " + defender.GetPhysicalArmor ();
		if (UnitUtils.DirectionCalc (unitAtk, defender) == (int) Attack.Direction.Front)
		aimCalcString += " - " + defender.GetFrontDodge ();
	}

	public void SetDefender (ArrayList defenderList) {
		foreach (Unit defender in defenderList) {
			damageCalcString += " - " + defender.GetPhysicalArmor ();
		}
	}
}

