global using Xunit;
using DungeonMasterApp;

namespace Assignment1Test
{
    public class HeroTest
    {
        [Fact]
        public void Create_Wizard()
        {
            string wizardname = "Karthus";

            Wizard wizard = new Wizard(wizardname);

            Assert.NotNull(wizard);
            Assert.Equal(1, wizard.Level);
            Assert.Equal(1, wizard.HeroAttribute.Strength);
            Assert.Equal(1, wizard.HeroAttribute.Dexterity);
            Assert.Equal(8, wizard.HeroAttribute.Intelligence);
        }

        [Fact]
        public void LevelUp_Wizard() 
        {
            string wizardname = "Karthus";

            Wizard wizard = new Wizard(wizardname);

            wizard.LevelUp();

            Assert.Equal(2, wizard.Level);
            Assert.Equal(2, wizard.HeroAttribute.Strength);
            Assert.Equal(2, wizard.HeroAttribute.Dexterity);
            Assert.Equal(13, wizard.HeroAttribute.Intelligence);
        }

        [Fact]
        public void Create_Archer()
        {
            string archername = "Varus";

            Archer archer = new Archer(archername);

            Assert.NotNull(archer);
            Assert.Equal(1, archer.Level);
            Assert.Equal(1, archer.HeroAttribute.Strength);
            Assert.Equal(7, archer.HeroAttribute.Dexterity);
            Assert.Equal(1, archer.HeroAttribute.Intelligence);
        }

        [Fact]
        public void LevelUp_Archer()
        {
            string archername = "Varus";

            Archer archer = new Archer(archername);

            archer.LevelUp();

            Assert.Equal(2, archer.Level);
            Assert.Equal(2, archer.HeroAttribute.Strength);
            Assert.Equal(12, archer.HeroAttribute.Dexterity);
            Assert.Equal(2, archer.HeroAttribute.Intelligence);
        }

        [Fact]
        public void Create_Swashbuckler()
        {
            string swashbucklername = "Samira";

            Swashbuckler swashbuckler = new Swashbuckler(swashbucklername);

            Assert.NotNull(swashbuckler);
            Assert.Equal(1, swashbuckler.Level);
            Assert.Equal(2, swashbuckler.HeroAttribute.Strength);
            Assert.Equal(6, swashbuckler.HeroAttribute.Dexterity);
            Assert.Equal(1, swashbuckler.HeroAttribute.Intelligence);
        }

        [Fact]
        public void LevelUp_Swashbuckler()
        {
            string swashbucklername = "Samira";

            Swashbuckler swashbuckler = new Swashbuckler(swashbucklername);

            swashbuckler.LevelUp();

            Assert.Equal(2, swashbuckler.Level);
            Assert.Equal(3, swashbuckler.HeroAttribute.Strength);
            Assert.Equal(10, swashbuckler.HeroAttribute.Dexterity);
            Assert.Equal(2, swashbuckler.HeroAttribute.Intelligence);
        }

        [Fact]
        public void Create_Barbarian()
        {
            string barbarianName = "Olaf";

            Barbarian barbarian = new Barbarian(barbarianName);

            Assert.NotNull(barbarian);
            Assert.Equal(1, barbarian.Level);
            Assert.Equal(5, barbarian.HeroAttribute.Strength);
            Assert.Equal(2, barbarian.HeroAttribute.Dexterity);
            Assert.Equal(1, barbarian.HeroAttribute.Intelligence);
        }

        [Fact]
        public void LevelUp_Barbarian()
        {
            string barbarianName = "Olaf";

            Barbarian barbarian = new Barbarian(barbarianName);

            barbarian.LevelUp();

            Assert.Equal(2, barbarian.Level);
            Assert.Equal(8, barbarian.HeroAttribute.Strength);
            Assert.Equal(4, barbarian.HeroAttribute.Dexterity);
            Assert.Equal(2, barbarian.HeroAttribute.Intelligence);
        }
    }
}