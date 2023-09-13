using System;

namespace DungeonMasterApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create a wizard
            Wizard wizard = new Wizard("WizardName");
            Weapon LargeRod = new Weapon("Large rod", 5, Slot.Weapon, WeaponType.Staffs, 70);
            Armor NullMagicMantle = new Armor("Null-Magic Mantle", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(0, 2, 0));
            Armor NinjaTabi = new Armor("Ninja tabi", 1, Slot.Legs, ArmorType.Cloth, new HeroAttribute(0, 2, 2));
            Armor Deathcap = new Armor("Rabadons deathcap", 5, Slot.Head, ArmorType.Cloth, new HeroAttribute(0, 2, 10));
            wizard.LevelUp();
            wizard.LevelUp();
            wizard.LevelUp();
            wizard.LevelUp();
            wizard.EquipWeapon(LargeRod);
            wizard.EquipArmor(NullMagicMantle);
            wizard.EquipArmor(NinjaTabi);
            wizard.EquipArmor(Deathcap);

            Console.WriteLine("\nWizard Details:");
            wizard.Display();
        }
    }
}
