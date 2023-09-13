namespace DungeonMasterApp
{
    public class Barbarian : Hero
    {
        public Barbarian(string name) : base(name)
        {
            Class = "Barbarian";
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Hatchets, WeaponType.Maces, WeaponType.Swords };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Plate, ArmorType.Mail };
            HeroAttribute = new HeroAttribute(5, 2, 1);
        }


        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute.IncreaseStrength(3);
            HeroAttribute.IncreaseDexterity(2);
            HeroAttribute.IncreaseIntelligence(1);
        }
    }
}

