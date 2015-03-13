public class WoodenSword : Weapon {
	public WoodenSword () {
		name = "Wooden Sword";
		description = "Sword created with the highest caliber of wood! Made in Changnos";
		weaponType = (int) WeaponType.Melee;
		weaponSlot = (int) WeaponSlot.OneHanded;
		physicalAttack = 10;
		physicalRange = 1;
	}
}

