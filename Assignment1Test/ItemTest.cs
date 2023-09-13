using DungeonMasterApp;


namespace Assignment1Test
{
    public class ItemTest
    {
        [Fact]
        public void Create_Weapon()
        {
            Weapon weapon = new Weapon("Blade of the Ruined King", 90, Slot.Weapon, WeaponType.Swords, 95);

            Assert.NotNull(weapon);
            Assert.Equal("Blade of the Ruined King", weapon.Name);
            Assert.Equal(90, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
            Assert.Equal(WeaponType.Swords, weapon.Type);
            Assert.Equal(95, weapon.WeaponDamage);
        }

        [Fact]
        public void Create_Armor()
        {
            Armor armor = new Armor("Thornmail", 90, Slot.Body, ArmorType.Mail, new HeroAttribute(45, 30, 10));

            Assert.NotNull(armor);
            Assert.Equal("Thornmail", armor.Name);
            Assert.Equal(90, armor.RequiredLevel);
            Assert.Equal(Slot.Body, armor.Slot);
            Assert.Equal(ArmorType.Mail, armor.Type);
            Assert.Equal(85, armor.ArmorAttribute.TotalAttribute());
        }
    }
}
