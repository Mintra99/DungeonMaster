using System.Collections.Generic;
using System.Linq;


namespace DungeonMasterApp
{
    public abstract class Hero
    {
        // Shared Fields
        public string Name { get; private set; }
        public string Class { get; set; }
        public int Level { get; private set; }
        public HeroAttribute HeroAttribute { get; set; } // Replace LevelAttributes with HeroAttribute
        public Dictionary<Slot, Item> Equipments { get; private set; }
        public List<WeaponType> ValidWeaponTypes { get; set; }
        public List<ArmorType> ValidArmorTypes { get; set; }

        // Constructor
        public Hero(string name)
        {
            Name = name;
            Level = 1;
            HeroAttribute = new HeroAttribute(); // Initialize HeroAttribute
            Equipments = new Dictionary<Slot, Item>();
            ValidWeaponTypes = new List<WeaponType>();
            ValidArmorTypes = new List<ArmorType>();
        }

        // Level up the hero
        public virtual void LevelUp()
        {
            Level++;
        }

        // Equip a weapon
        public void EquipWeapon(Weapon weapon)
        {
            if (ValidWeaponTypes.Contains(weapon.Type) && Level >= weapon.RequiredLevel)
            {
                if (!Equipments.ContainsKey(weapon.Slot))
                {
                    Equipments.Add(weapon.Slot, weapon);
                }
                else
                {
                    Equipments[weapon.Slot] = weapon;
                }
            }
            else
            {
                // Handle invalid weapon type exception
                throw new InvalidWeaponExcepition($"Invalid weapon type: {weapon.Type}");
            }
        }

        // Equip armor
        public void EquipArmor(Armor armor)
        {
            if (ValidArmorTypes.Contains(armor.Type) && Level >= armor.RequiredLevel)
            {
                if (!Equipments.ContainsKey(armor.Slot))
                {
                    Equipments.Add(armor.Slot, armor);
                }
                else
                {
                    Equipments[armor.Slot] = armor;
                }
            }
            else
            {
                // Handle invalid armor type exception
                throw new InvalidArmorExcepition($"Invalid armor type: {armor.Type}");
            }
        }

        public int CalculateTotalAttribute()
        {
            int totalArmorAttr = 0;
            int totalHeroAttr = 0;

            foreach (var equipment in Equipments.Values)
            {
                if (equipment is Armor armor)
                {
                    totalArmorAttr += armor.ArmorAttribute.TotalAttribute();
                }
            }

            // Calculate the total hero attribute using HeroAttribute
            totalHeroAttr = HeroAttribute.TotalAttribute();


            Console.WriteLine(totalHeroAttr);
            return totalArmorAttr + totalHeroAttr;
        }

        // Calculate and return damage (on-the-fly)
        public int CalculateDamage()
        {
            int damageAttribute = 0;
            int totDmg;
            Weapon weapon;
            if (Equipments.ContainsKey(Slot.Weapon))
            {
                Item item = Equipments[Slot.Weapon];
                weapon = (Weapon)item;

                switch (Class)
                {
                    case "Barbarian":
                        damageAttribute = HeroAttribute.Strength;
                        break;
                    case "Wizard":
                        damageAttribute = HeroAttribute.Intelligence;
                        break;
                    default:
                        damageAttribute = HeroAttribute.Dexterity;
                        break;
                }

                totDmg = weapon.WeaponDamage * (100 + damageAttribute) / 100;
            }
            else
            {
                totDmg = 1 * (1 + damageAttribute / 100);
            }

            // Implement damage calculation logic based on equipped weapons, attributes, etc.
            return totDmg;
        }

        // Display hero details
        public void Display()
        {
            Console.WriteLine($"- Name: {Name}");
            Console.WriteLine($"- Class: {Class}");
            Console.WriteLine($"- Level: {Level}");
            Console.WriteLine("------------------");
            Console.WriteLine("Hero Attributes:"); // Change to "Hero Attributes" from "Level Attributes"

            // Display the hero attributes using HeroAttribute
            Console.WriteLine($"- Strength: {HeroAttribute.Strength}");
            Console.WriteLine($"- Dexterity: {HeroAttribute.Dexterity}");
            Console.WriteLine($"- Intelligence: {HeroAttribute.Intelligence}");

            Console.WriteLine($"- Total attribute: {CalculateTotalAttribute()}");
            Console.WriteLine($"- Damage: {CalculateDamage()}");
            Console.WriteLine("------------------");
            Console.WriteLine("Equipments:");
            foreach (var Equipment in Equipments)
            {
                Console.WriteLine($"- {Equipment.Value.Name} ({Equipment.Key})");
            }
        }
    }
}
