using RPG_Assignment_1.Game;
using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Character;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RPG_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {


            CreateHero Hero = new CreateHero("Dumbledoor", HeroTypes.Mage, new Mage());
            Console.WriteLine($"Here is your Hero named {Hero.Name}! Your stats before leveling up are:");
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Press any key to level up!");
            Console.ReadLine();
            Console.Clear();
            Hero.LevelUp(1);
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Press any key to level up!");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Hero.LevelUp(1);
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Press any key to Add Armor");
            Console.ReadLine();
            Console.Clear();
            Hero.AddArmor(new Armor()
            {

                Name = "Common plate body armor",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Cloth,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }

            });

            //Hero.ReCalcDPS();
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Press any key to A weapon");
            Console.ReadLine();
            Console.Clear();
            Hero.AddWeapon(new Weapon()
            {

                Name = "Common Slow Staff",
                RequiredLevel = 3,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Staff,
                WeaponAttributes = new WeaponAttributes { Damage = 2, AttackSpeed = 1.1 }

            });
            
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.ReadLine();
            Console.WriteLine("Add more armor to check if DPS recalcs");
            Console.ReadLine();
            Console.Clear();
            Hero.AddWeapon(new Weapon()
            {

                Name = "Common Slow Staff",
                RequiredLevel = 3,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Staff,
                WeaponAttributes = new WeaponAttributes { Damage = 2, AttackSpeed = 1.1 }

            });
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
        }
    }
}
