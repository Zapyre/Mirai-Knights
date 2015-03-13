public class WoodenCane : Weapon {
	public WoodenCane () {
		name = "Wooden Cane";
		description = "Cane created with the highest caliber of wood! Made in Changnos";
		weaponType = (int) WeaponType.Melee;
		weaponSlot = (int) WeaponSlot.TwoHanded;
		physicalAttack = 5;
		physicalRange = 1;
		magicAttack = 5;
		magicRange = 1;
	}
}
