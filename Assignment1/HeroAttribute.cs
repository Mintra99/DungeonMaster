namespace DungeonMasterApp
{
    public class HeroAttribute
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public HeroAttribute(int strength=0, int dexterity = 0, int intelligence = 0)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
        }

        public void IncreaseStrength(int amount)
        {
            Strength += amount;
        }

        public void IncreaseDexterity(int amount)
        {
            Dexterity += amount;
        }

        public void IncreaseIntelligence(int amount)
        {
            Intelligence += amount;
        }

        public int TotalAttribute()
        {
            return Strength + Dexterity + Intelligence;
        }
    }
}
