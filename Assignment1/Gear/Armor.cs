namespace DungeonMasterApp
{

    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    public class Armor : Item
    {
        public ArmorType Type { get; private set; }
        public HeroAttribute ArmorAttribute { get; private set; }

        public Armor(string name, int requiredLevel, Slot slot, ArmorType type, HeroAttribute armorAttribute) : base(name, requiredLevel, slot)
        {
            Type = type;
            ArmorAttribute = armorAttribute;
        }
    }
}
