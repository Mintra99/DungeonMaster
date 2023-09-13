using DungeonMasterApp;


namespace Assignment1Test
{
    public class CalculateStatsTest
    {
        [Fact]
        public void Total_Attribute_sum()
        {
            Archer archer = new Archer("Varus");
            Armor body = new Armor("Leather Armor", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(0, 2, 0));
            Armor legs = new Armor("Leather Boots", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(0, 1, 0));
            Armor body2 = new Armor("Thornmail", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(45, 30, 10));

            Assert.Equal(9, archer.CalculateTotalAttribute());

            archer.EquipArmor(body);
            Assert.Equal(11, archer.CalculateTotalAttribute());

            archer.EquipArmor(legs);
            Assert.Equal(12, archer.CalculateTotalAttribute());

            archer.EquipArmor(body2);
            Assert.Equal(95, archer.CalculateTotalAttribute());
        }

        [Fact]
        public void Total_Damage_sum()
        {
            Archer archer = new Archer("Varus");
            Weapon bow1 = new Weapon("Recurve Bow", 1, Slot.Weapon, WeaponType.Bows, 3);
            Weapon bow2 = new Weapon("Kraken Slayer", 1, Slot.Weapon, WeaponType.Bows, 40);
            Armor body = new Armor("Leather Armor", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(0, 2, 0));

            Assert.Equal(1, archer.CalculateDamage());

            archer.EquipWeapon(bow1);
            Assert.Equal(3, archer.CalculateDamage());

            archer.EquipWeapon(bow2);
            Assert.Equal(42, archer.CalculateDamage());

            archer.EquipArmor(body);
            Assert.Equal(11, archer.CalculateTotalAttribute());
        }
    }
}
