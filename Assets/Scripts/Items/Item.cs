using UnityEngine;
using System.Collections;
using System;

public abstract class Item {
	public enum ItemType { Weapon, Armor, Consumable };
	protected string name;
	protected string description;

	protected int physicalAttack;
	protected int physicalRange;
	protected int [] block = new int [Enum.GetNames(typeof(Attack.Direction)).Length];

	protected int speed;
	protected int [] dodge = new int [Enum.GetNames(typeof(Attack.Direction)).Length];
	protected int phyisicalAim;

	protected int magicAttack;
	protected int magicAim;
	protected int magicRange;

	protected int health;
	protected int shield;

	protected int actionPoints;
	protected int jump;
	protected int physicalArmor;
	protected int magicArmor;
	
	// Getters
	public string GetName () { return name; }

	public int GetPhysicalAttack () { return physicalAttack; }
	public int GetPhysicalRange () { return physicalRange; }
	public int GetBlock (int dir) { return block [dir]; }

	public int GetSpeed () { return speed; }
	public int GetDodge (int dir) { return dodge [dir]; }
	public int GetPhyisicalAim () { return phyisicalAim; }

	public int GetMagicAttack () { return magicAttack; }
	public int GetMagicAim () { return magicAim; }
	public int GetMagicRange () { return magicRange; }

	public int GetHealth () { return health; }
	public int GetShield () { return shield; }

	public int GetActionPoints () { return actionPoints; }
	public int GetJump () { return jump; }
	public int GetPhysicalArmor () { return physicalArmor; }
	public int GetMagicArmor () { return magicArmor; }
}
