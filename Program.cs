using RPG_Assignment_1.Game;
using RPG_Assignment_1.Game.Character;
using RPG_Assignment_1.Game.Enums;
using System;


namespace RPG_Assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {

            CreateHero Hero = new CreateHero("Padawan", HeroTypes.Warrior, new Warrior());
            Console.WriteLine($"Here is your Hero named {Hero.Name}! Your stats before leveling up are:");
            Console.WriteLine();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine();
            Console.WriteLine("Level 1 and adding a Level 1 Axe");
            Console.ReadLine();
            Console.Clear();
            Hero.AddWeapon(AvailableWeapon.Axe_Level1);
            Console.WriteLine(Hero.ToString());
            Console.WriteLine();
            Console.WriteLine("Level 1 and adding a Level 1 Armor");
            Console.ReadLine();
            Console.Clear();
            Hero.AddArmor(AvailableArmor.PlateBody_Level1);
            Console.WriteLine(Hero.ToString());
            Console.WriteLine();
            Console.WriteLine("Level up Character");
            Console.ReadLine();
            Hero.LevelUp(1);
            Console.Clear();
            Console.WriteLine(Hero.ToString());
            Console.WriteLine("Level 2 and adding a Level 4 Armor");
            Console.ReadLine();
            Hero.AddArmor(AvailableArmor.Plate_Level4);
        }
    }
}
