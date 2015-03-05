using UnityEngine;
using System.Collections;
public class ManaBlast : Attack {
	protected string damageCalcString;
	protected string rangeCalcString;
	protected string aimCalcString;
	protected int damage;
	protected int range;
	protected int aim;
	
	public ManaBlast (Unit attacker){
		damage = attacker.GetMagicDamage ();
		range = attacker.GetMagicRange ();
		aim = attacker.GetMagicAim ();
		damageCalcString = "Damage: " + damage;
		rangeCalcString = "Range: " + range;
		aimCalcString = "Aim: " + aim;
	}
	
	public void SetDefender (Unit defender){
		damageCalcString += " - " + defender.GetMagicArmor ();
	}
	
	public void SetDefender (ArrayList defenderList){
		foreach (Unit defender in defenderList) {
			damageCalcString += " - " + defender.GetMagicArmor ();
		}
	}
}
