# Dungeon Master

The Dungeon Master Application is a C# program that allows you to create and manage various heroes, equip them with weapons and armor, and simulate battles in a fantasy world. This README provides an overview of the code structure and functionality of the application.

## Getting started
To run the Dungeon Master Application, follow these steps:

    1. Clone or download the repository to your local machine.
    2. Open the project in a C# development environment (e.g., Visual Studio).
    3. Build and run the project to execute the application.



## Code structure
* **Program.cs:** The entrypoint of the application.
* **Hero.cs:** The base class for all hero types. It includes shared dields and methods for heroes.
* **Classes:** Subclasses of heroes (e.g. Wizard, Archer, Barbarian, Swashbuckler) are defined here.
* **Exception:** Custom exception classes for handling equipment-related errors.
* **Gear:** Classes representing equipment items (Armor and Weapon) are defined here.
* **Item.cs:** The parent class for equipment items. It includes shared fields for all items.
 
## Creating heroes
To create a hero, you can choose from various classes such as Wizard, Archer, Barbarian and Swashbuckler. Each hero has a name, level and attributes (Strength, Dexterity and Intelligence). You can create a hero instance by providing a name. Example:

```
    Wizard wizard = new Wizard("Name");
```

## Create items
Heroes can equip weapns and armor. There are different types of weapons and armor, each with its own requirements. You can equip an item to a hero using the **EquipWeapon** or **EquipArmor** methods. Example:

```
    Weapon LargeRod = new Weapon("Large rod", 5, Slot.Weapon, WeaponType.Staffs, 70);
    Armor NullMagicMantle = new Armor("Null-Magic Mantle", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(0, 2, 0));
    Armor NinjaTabi = new Armor("Ninja tabi", 1, Slot.Legs, ArmorType.Cloth, new HeroAttribute(0, 2, 2));
    Armor Deathcap = new Armor("Rabadons deathcap", 5, Slot.Head, ArmorType.Cloth, new HeroAttribute(0, 2, 10));

    wizard.EquipWeapon(LargeRod);
    wizard.EquipArmor(NullMagicMantle);
    wizard.EquipArmor(NinjaTabi);
    wizard.EquipArmor(Deathcap);

```


## Testing
Unit tests for various functionalities are provided in the AssignmentTest project. You can run these tests to ensure the correctness of the code.

## Contributions
* Minh Christian Tran ([@Mintra99](https://github.com/Mintra99))


