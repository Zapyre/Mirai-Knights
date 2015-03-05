public class WoodenCane : Weapon {
	public WoodenCane () {
		name = "Wooden Cane";
		weaponType = (int) WeaponType.Melee;
		weaponSlot = (int) WeaponSlot.TwoHanded;
		physicalAttack = 5;
		physicalRange = 1;
		magicAttack = 5;
		magicRange = 1;
	}
}
