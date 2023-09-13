namespace DungeonMasterApp
{
    public class Swashbuckler : Hero
    {
        public Swashbuckler(string name) : base(name)
        {
            Class = "Swashbuckler";
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Daggers, WeaponType.Swords };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };
            HeroAttribute = new HeroAttribute(2, 6, 1);
        }


        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute.IncreaseStrength(1);
            HeroAttribute.IncreaseDexterity(4);
            HeroAttribute.IncreaseIntelligence(1);
        }
    }
}