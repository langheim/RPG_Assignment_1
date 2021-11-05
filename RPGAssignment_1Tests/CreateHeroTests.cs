using RPG_Assignment_1.Game;
using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Character;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System;
using Xunit;
using RPG_Assignment_1;
using System.IO;

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

            Hero.AddWeapon(new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 2,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Axe,
                WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
            }));

        }

        [Fact]
        public void Equipt_HigLevelArmor_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidArmorException>(() =>

            Hero.AddArmor(new Armor()
            {
                Name = "Common mail body armor",
                RequiredLevel = 2,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Mail,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 4, Strength = 4 }
            }));
        }

        [Fact]
        public void Equipt_Wrong_WeaponType_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidWeaponException>(() =>

            Hero.AddWeapon(new Weapon()
            {
                Name = "Common Bow",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Bow,
                WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
            }));

        }

        [Fact]
        public void Equipt_Wrong_ArmorType_Should_Return_Exception()
        {
            //Arrange
            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Assert.Throws<InvalidArmorException>(() =>

            Hero.AddArmor(new Armor()
            {
                Name = "Common mail body armor",
                RequiredLevel = 2,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Mail,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 4, Strength = 4 }
            }));
        }

        [Fact]
        public void Equipt_Weapon_Should_Return_Weapon_Equipted_Message()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

                CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

                //Act & Assert
                Hero.AddWeapon(new Weapon()
                {
                    Name = "Common Bow",
                    RequiredLevel = 1,
                    SlotTypes = SlotTypes.Weapon,
                    WeaponTypes = WeaponTypes.Sword,
                    WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
                });

            var output = stringWriter.ToString();
            Assert.Equal($"New Weapon equipped!\r\n", output); ;
            
        }

        [Fact]
        public void Equipt_Armor_Should_Return_Armor_Equipted_Message()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddArmor(new Armor()
            {
                Name = "Common Armor",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Plate,
            });

            var output = stringWriter.ToString();
            Assert.Equal($"New Armour equipded!\r\n", output); ;

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

            Assert.Equal(calculation.ToString(), DPS); ;

        }
        [Fact]
        public void Calculate_DPS_with_Weapon_Axe()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddWeapon(new Weapon()
            {
                Name = "Common Axe",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Axe,
                WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
            });
            var DPS = (Hero.BasePrimaryAttributes.DPS).ToString();

            var output = stringWriter.ToString();
            double calculation = (7 * 1.1) * (1 + (5 / 100));

            Assert.Equal(calculation.ToString(), DPS); ;

        }
        [Fact]
        public void Calculate_DPS_with_Weapon_Axe_And_Pate_Armor()
        {
            //Arrange
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());

            //Act & Assert
            Hero.AddWeapon(new Weapon()
            {
                Name = "Common Axe",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Axe,
                WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
            });
            Hero.AddArmor(new Armor()
            {
                Name = "Common Armor",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Plate,
            });

            var DPS = (Hero.BasePrimaryAttributes.DPS).ToString();

            var output = stringWriter.ToString();
            double calculation = (7 * 1.1) * (1 + ((5 + 1) / 100));

            Assert.Equal(calculation.ToString(), DPS); ;

        }
    }
}
