using RPG_Assignment_1;
using RPG_Assignment_1.Game;
using RPG_Assignment_1.Game.Character;
using RPG_Assignment_1.Game.Enums;
using System;
using System.IO;
using Xunit;

namespace RPGAssignment_1Tests
{
    public class CreateHeroTests
    {
        public InvalidLevelException thrownException;

        [Fact]
        public void Equipt_HigLevelWeapon_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidWeaponException>(() =>

            Hero.AddWeapon(AvailableWeapon.GreatSword_Level5));

        }

        [Fact]
        public void Equipt_HigLevelArmor_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidArmorException>(() =>

            Hero.AddArmor(AvailableArmor.Plate_Level4));
        }

        [Fact]
        public void Equipt_Wrong_WeaponType_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidWeaponException>(() =>

            Hero.AddWeapon(AvailableWeapon.Bow_Level1));

        }

        [Fact]
        public void Equipt_Wrong_ArmorType_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidArmorException>(() =>

            Hero.AddArmor(AvailableArmor.ClothHead_Level1));
        }

        [Fact]
        public void Equipt_Weapon_Should_Return_Weapon_Equipted_Message()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddWeapon(AvailableWeapon.Hammer_Level1);

            var output = stringWriter.ToString();
            Assert.Equal($"New Weapon equipped!\r\n", output);

        }

        [Fact]
        public void Equipt_Armor_Should_Return_Armor_Equipted_Message()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddArmor(AvailableArmor.PlateBody_Level1);

            var output = stringWriter.ToString();
            Assert.Equal($"New Armour equipded!\r\n", output);

        }

        [Fact]
        public void Calculate_DPS_No_Weapon()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            var DPS = (Hero.BasePrimaryAttributes.DPS).ToString();

            var output = stringWriter.ToString();
            double calculation = 1 * (1 + (5 / 100));

            Assert.Equal(calculation.ToString(), DPS);

        }
        [Fact]
        public void Calculate_DPS_with_Weapon_Axe()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddWeapon(AvailableWeapon.Axe_Level1);

            var DPS = (Hero.BasePrimaryAttributes.DPS).ToString();

            var output = stringWriter.ToString();
            double calculation = 8.085;

            Assert.Equal(calculation.ToString(), DPS);

        }
        [Fact]
        public void Calculate_DPS_with_Weapon_Axe_And_Pate_Armor()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddWeapon(AvailableWeapon.Axe_Level1);
            Hero.AddArmor(AvailableArmor.PlateBody_Level1);

            var DPS = (Hero.BasePrimaryAttributes.DPS).ToString();

            var output = stringWriter.ToString();
            double calculation = 8.624000000000002;

            Assert.Equal(calculation.ToString(), DPS);
        }
    }
}
