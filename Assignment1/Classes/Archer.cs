namespace DungeonMasterApp
{
    public class Archer : Hero
    {
        public Archer(string name) : base(name)
        {
            Class = "Archer";
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Bows };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
            HeroAttribute = new HeroAttribute(1, 7, 1);
        }


        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute.IncreaseStrength(1);
            HeroAttribute.IncreaseDexterity(5);
            HeroAttribute.IncreaseIntelligence(1);
        }
    }
}
