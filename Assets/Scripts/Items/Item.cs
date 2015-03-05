using UnityEngine;
using System.Collections;
public abstract class Item {
	public enum ItemType { Weapon, Armor, Consumable };
	protected string name;

	protected int physicalAttack;
	protected int physicalRange;
	protected int frontBlock;
	protected int sideBlock;
	protected int backBlock;

	protected int speed;
	protected int frontDodge;
	protected int sideDodge;
	protected int backDodge;
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
	public int GetFrontBlock () { return frontBlock; }
	public int GetSideBlock () { return sideBlock; }
	public int GetBackBlock () { return backBlock; }

	public int GetSpeed () { return speed; }
	public int GetFrontDodge () { return frontDodge; }
	public int GetSideDodge () { return sideDodge; }
	public int GetBackDodge () { return backDodge; }
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
