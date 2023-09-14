using DungeonMasterApp;
using System.Text;


namespace Assignment1Test
{
    public class DisplayStateTest
    {
        [Fact]
        public void Display_Hero_State_No_Items()
        {
            string wizardname = "Karthus";
            Wizard wizard = new Wizard(wizardname);

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"- Name: {wizardname}");
            stringBuilder.AppendLine("- Class: Wizard");
            stringBuilder.AppendLine("- Level: 1");
            stringBuilder.AppendLine("------------------");
            stringBuilder.AppendLine("Hero Attributes:");

            // Display the hero attributes using HeroAttribute
            stringBuilder.AppendLine($"- Strength: 1");
            stringBuilder.AppendLine($"- Dexterity: 1");
            stringBuilder.AppendLine($"- Intelligence: 8");

            stringBuilder.AppendLine($"- Total Strength: 1");
            stringBuilder.AppendLine($"- Total Dexterity: 1");
            stringBuilder.AppendLine($"- Total Intelligence: 8");

            stringBuilder.AppendLine($"- Total attribute: 10");
            stringBuilder.AppendLine($"- Damage: 1");
            stringBuilder.AppendLine("------------------");
            stringBuilder.AppendLine("Equipments:");

            string expected = stringBuilder.ToString();
            string Actual = wizard.Display();

            Assert.Equal( expected, Actual );
            
        }

        [Fact]
        public void Display_Hero_State_With_Items()
        {
            string wizardname = "Karthus";
            Wizard wizard = new Wizard(wizardname);

            Weapon validweapon = new Weapon("Rod of Ages", 1, Slot.Weapon, WeaponType.Staffs, 95);
            Armor validBodyArmor = new Armor("Cloth Armor", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(45, 30, 10));
            Armor validHeadArmor = new Armor("Cloth Helmet", 1, Slot.Head, ArmorType.Cloth, new HeroAttribute(0, 0, 2));

            wizard.EquipWeapon(validweapon);
            wizard.EquipArmor(validBodyArmor);
            wizard.EquipArmor(validHeadArmor);


            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"- Name: {wizardname}");
            stringBuilder.AppendLine("- Class: Wizard");
            stringBuilder.AppendLine("- Level: 1");
            stringBuilder.AppendLine("------------------");
            stringBuilder.AppendLine("Hero Attributes:");

            // Display the hero attributes using HeroAttribute
            stringBuilder.AppendLine($"- Strength: 1");
            stringBuilder.AppendLine($"- Dexterity: 1");
            stringBuilder.AppendLine($"- Intelligence: 8");

            stringBuilder.AppendLine($"- Total Strength: 46");
            stringBuilder.AppendLine($"- Total Dexterity: 31");
            stringBuilder.AppendLine($"- Total Intelligence: 20");

            stringBuilder.AppendLine($"- Total attribute: 97");
            stringBuilder.AppendLine($"- Damage: 102");
            stringBuilder.AppendLine("------------------");
            stringBuilder.AppendLine("Equipments:");

            stringBuilder.AppendLine("- Rod of Ages (Weapon)");
            stringBuilder.AppendLine("- Cloth Armor (Body)");
            stringBuilder.AppendLine("- Cloth Helmet (Head)");

            string expected = stringBuilder.ToString();
            string Actual = wizard.Display();

            Assert.Equal(expected, Actual);
        }
    }
}
