namespace DungeonMasterApp
{
    public enum Slot
    {
        Weapon,
        Head,
        Body,
        Legs
    }

    public abstract class Item
    {
        // Shared Fields
        public string Name { get; protected set; }
        public int RequiredLevel { get; protected set; }
        public Slot Slot { get; protected set; }


        // Constructor
        public Item(string name, int requiredLevel, Slot slot)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
        }

    }
}
