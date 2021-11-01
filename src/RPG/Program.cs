using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Hero.AddNewArmor("Common cloth head armor", ArmorTypes.Cloth, 1, SlotTypes.Body, new PrimaryAttributes { Inteligence = 30, Dexterity = 30 });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Now try to add some more Armor!");
            Console.WriteLine("Press any key to Add more Armor!");
            Console.ReadLine();
            Console.Clear();

            Hero.AddNewArmor("Large Helmet", ArmorTypes.Leather, 15, SlotTypes.Head, new PrimaryAttributes { Vitality = 20, Strengt = 10 });
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Now to add a new Weapon!");
            Console.WriteLine("Press any key to Add a Weapon.");
            Console.ReadLine();
            Console.WriteLine();
            Console.Clear();

            Hero.AddNewWeapon("Common Staff", WeaponTypes.Staff, 20, SlotTypes.Weapon, 7, 1.1);
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.ReadLine();
        }
    }
}
