namespace DungeonMasterApp
{

    public enum WeaponType
    {
        Hatchets,
        Bows,
        Daggers,
        Maces,
        Staffs,
        Swords,
        Wands
    }
    public class Weapon : Item
    {
        public WeaponType Type { get; private set; }
        public int WeaponDamage { get; private set; }
        

        public Weapon(string name, int requiredLevel, Slot slot, WeaponType type, int weaponDamage) : base(name, requiredLevel, slot)
        {
            Type = type;
            WeaponDamage = weaponDamage;
        }
    }
}
