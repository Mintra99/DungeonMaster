namespace DungeonMasterApp
{
    public class Wizard : Hero
    {
        public Wizard(string name) : base(name) 
        {
            Class = "Wizard";
            ValidWeaponTypes = new List<WeaponType> { WeaponType.Wands, WeaponType.Staffs };
            ValidArmorTypes = new List<ArmorType> { ArmorType.Cloth };
            HeroAttribute = new HeroAttribute(1, 1, 8);
        }


        public override void LevelUp()
        {
            base.LevelUp();
            HeroAttribute.IncreaseStrength(1);
            HeroAttribute.IncreaseDexterity(1);
            HeroAttribute.IncreaseIntelligence(5);
        }
    }
}