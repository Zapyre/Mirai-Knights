public class WoodenShield : Weapon {
	public WoodenShield () {
		name = "Wooden Shield";
		description = "Shield created with the highest caliber of wood! Made in Changnos";
		weaponType = (int) WeaponType.Shield;
		weaponSlot = (int) WeaponSlot.OneHanded;
		physicalArmor = 2;
		magicArmor = 2;
	}
}