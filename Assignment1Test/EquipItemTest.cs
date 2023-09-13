using DungeonMasterApp;

namespace Assignment1Test
{
    public class EquipItemTest
    {
        [Fact]
        public void Equip_Weapon_And_Armor_Invalid()
        {
            Barbarian barbarian = new Barbarian("Olaf");
            Weapon weaponInvalidLevel = new Weapon("Blade of the Ruined King", 90, Slot.Weapon, WeaponType.Swords, 95);
            Weapon weaponInvalidtype = new Weapon("Recurve Bow", 1, Slot.Weapon, WeaponType.Bows, 3);
            Armor armorInvalidLevel = new Armor("Thornmail", 90, Slot.Body, ArmorType.Mail, new HeroAttribute(45, 30, 10));
            Armor armorInvalidType = new Armor("Cloth Armor", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(0, 0, 2));

            Assert.Throws<InvalidWeaponExcepition>(() => barbarian.EquipWeapon(weaponInvalidLevel));
            Assert.Throws<InvalidWeaponExcepition>(() => barbarian.EquipWeapon(weaponInvalidtype));
            Assert.Throws<InvalidArmorExcepition>(() => barbarian.EquipArmor(armorInvalidLevel));
            Assert.Throws<InvalidArmorExcepition>(() => barbarian.EquipArmor(armorInvalidType));
        }
    }
}
