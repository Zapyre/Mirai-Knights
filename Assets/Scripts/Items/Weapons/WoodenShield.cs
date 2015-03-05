public class WoodenShield : Weapon {
	public WoodenShield () {
		name = "Wooden Shield";
		weaponType = (int) WeaponType.Shield;
		weaponSlot = (int) WeaponSlot.OneHanded;
		physicalArmor = 2;
		magicArmor = 2;
	}
}