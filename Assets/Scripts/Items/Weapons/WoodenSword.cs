public class WoodenSword : Weapon {
	public WoodenSword () {
		name = "Wooden Sword";
		weaponType = (int) WeaponType.Melee;
		weaponSlot = (int) WeaponSlot.OneHanded;
		physicalAttack = 10;
		physicalRange = 1;
	}
}

