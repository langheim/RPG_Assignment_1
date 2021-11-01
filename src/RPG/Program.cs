using System;

namespace RPG_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHero Hero = new CreateHero("Dumbledoor", HeroTypes.Mage, new Mage());
            Console.WriteLine($"Here is your Hero named {Hero.Name}! Your stats before leveling up are:");
            Console.WriteLine("");
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Press any key to level up!");
            Console.ReadLine();
            Console.Clear();

            Hero.LevelUp();
            Console.WriteLine($"{Hero.Name}! You have now leveled up! new stats are:");
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine();
            Console.WriteLine("Press any key to level up Again!");
            Console.ReadLine();
            Console.Clear();

            Hero.LevelUp();
            Console.WriteLine($"{Hero.Name}! You have now leveled up again! new stats are:");
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine();
            Console.WriteLine("Now try to add some Armor!");
            Console.WriteLine("Press any key to Add Armor!");
            Console.ReadLine();
            Console.Clear();

            Hero.AddNewArmor("Cloak of Mordoor", ArmorTypes.Cloth, 3, SlotTypes.Body, new PrimaryAttributes { Inteligence = 5, Vitality = 1 });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Now try to add an Armor not suitable for you Hero's level!");
            Console.WriteLine("Press any key to Add new Armor!");
            Console.ReadLine();
            Console.Clear();

            Hero.AddNewArmor("Major Cloak Of Invincibility", ArmorTypes.Cloth, 15, SlotTypes.Body, new PrimaryAttributes { Inteligence = 15, Vitality = 10 });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Now try to add some more Armor not suitable for your class!");
            Console.WriteLine("Press any key to Add new Armor!");
            Console.ReadLine();
            Console.Clear();

            Hero.AddNewArmor("Large bulky Helmet", ArmorTypes.Plate, 2, SlotTypes.Head, new PrimaryAttributes { Vitality = 1, Strengt = 5 });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Now to add a new Weapon!");
            Console.WriteLine("Press any key to Add a Weapon.");
            Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            Hero.AddNewWeapon("Common Staff", WeaponTypes.Staff, 3, SlotTypes.Weapon, 7, 1.1);
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.ReadLine();
        }
    }
}
