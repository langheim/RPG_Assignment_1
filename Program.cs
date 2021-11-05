using RPG_Assignment_1.Game;
using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Character;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System;

namespace RPG_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            double number = (7 * 1.1) * (1 + ((5 + 1) / 100));

            Console.WriteLine(number);

            Console.ReadLine();

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());
            Console.WriteLine($"Here is your Hero named {Hero.Name}! Your stats before leveling up are:");
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Level 1 and adding an Axe");
            Console.ReadLine();
            Console.Clear();
            Hero.AddWeapon(new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Axe,
                WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
            });
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Level 1 and adding an Armor");
            Console.ReadLine();
            Console.Clear();
            Hero.AddArmor(new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Plate,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 3 }
            });
            Console.WriteLine("");
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
                ArmorTypes = ArmorTypes.Plate,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 3 }
            });
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Press any key to A weapon");
            Console.ReadLine();
            Console.Clear();
            Hero.AddWeapon(new Weapon()
            {
                Name = "Common axe",
                RequiredLevel = 3,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Axe,
                WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
            });
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.ReadLine();
            Console.WriteLine("Add more a new weapon to check if DPS recalcs");
            Console.ReadLine();
            Console.Clear();
            Hero.AddWeapon(new Weapon()
            {
                Name = "One bigAss sword",
                RequiredLevel = 3,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Sword,
                WeaponAttributes = new WeaponAttributes { Damage = 15, AttackSpeed = 1.3 }
            });
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("No to the Mage class");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            // Mage class
            Console.Clear();
            CreateHero Hero2 = new CreateHero("Dumbledoor", HeroTypes.Mage, new Mage());
            Console.WriteLine($"Here is your Hero named {Hero2.Name}! Your stats before leveling up are:");
            Console.WriteLine();
            Console.WriteLine(Hero2.ToString());
            Console.WriteLine("Press any key to level up!");
            Console.ReadLine();
            Console.Clear();
            Hero2.LevelUp(1);
            Console.WriteLine();
            Console.WriteLine(Hero2.ToString());
            Console.WriteLine("Press any key to level up!");
            Console.WriteLine();
            Console.ReadLine();
            Console.Clear();
            Hero2.LevelUp(1);
            Console.WriteLine();
            Console.WriteLine(Hero2.ToString());
            Console.WriteLine("Press any key to Add Armor");
            Console.ReadLine();
            Console.Clear();
            Hero2.AddArmor(new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Cloth,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
            });
            Console.WriteLine("");
            Console.WriteLine(Hero2.ToString());
            Console.WriteLine("Press any key to A weapon");
            Console.ReadLine();
            Console.Clear();
            Hero2.AddWeapon(new Weapon()
            {
                Name = "Common Slow Staff",
                RequiredLevel = 3,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Staff,
                WeaponAttributes = new WeaponAttributes { Damage = 2, AttackSpeed = 1.1 }

            });
            Console.WriteLine("");
            Console.WriteLine(Hero2.ToString());
            Console.ReadLine();
            Console.WriteLine("Add more a new weapon to check if DPS recalcs");
            Console.ReadLine();
            Console.Clear();
            Hero2.AddWeapon(new Weapon()
            {
                Name = "Uber magic Staff",
                RequiredLevel = 3,
                SlotTypes = SlotTypes.Weapon,
                WeaponTypes = WeaponTypes.Staff,
                WeaponAttributes = new WeaponAttributes { Damage = 10, AttackSpeed = 1.1 }
            });
            Console.WriteLine("");
            Console.WriteLine(Hero2.ToString());
            Console.WriteLine("Press some armor not suitable for you class");
            Console.ReadLine();
            Console.Clear();
            Hero2.AddArmor(new Armor()
            {
                Name = "Common plate body armor",
                RequiredLevel = 1,
                SlotTypes = SlotTypes.Body,
                ArmorTypes = ArmorTypes.Mail,
                BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 7 }
            });
        }
    }
}
