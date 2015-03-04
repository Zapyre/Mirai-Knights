using UnityEngine;
using System.Collections;
public class BasicMeleeAttack
{
	protected string damageCalcString;
	protected string rangeCalcString;
	protected int damage;
	protected int range;

	public BasicMeleeAttack (Unit attacker, Unit defender){
		damageCalcString = "Damage: ";
	}
}

