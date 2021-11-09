using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using RPG_Assignment_1.Game.Interfaces;
using RPG_Assignment_1.Game.Items;
using System.Linq;
using System.Text;

namespace RPG_Assignment_1.Game
{
    public class CreateHero
    {
        public string Name { get; init; }
        public int Level { get; private set; } = 1;
        public HeroTypes HeroTypes { get; init; }
        public PrimaryAttributes BasePrimaryAttributes { get; private set; }
        public SecondaryAttributes BaseSecondaryAttributes { get; private set; }
        public Armor BaseArmorAttribute { get; private set; }
        public Weapon BaseWeaponAttribute { get; private set; }
        public ArmorLists ArmorDirectory { get; private set; } = new ArmorLists();
        public WeaponLists WeaponDirectory { get; private set; } = new WeaponLists();
        public ICreateHero HeroClass { get; init; }
        /// <summary>
        /// Main class for createing the Hero
        /// </summary>
        /// <param name="name">Name of your Hero</param>
        /// <param name="heroTypes">Type of Hero to create</param>
        /// <param name="heroClass">Your class file containing your Hero</param>
        public CreateHero(string name, HeroTypes heroTypes, ICreateHero heroClass)
        {
            Name = name;
            HeroTypes = heroTypes;
            HeroClass = heroClass;
            SetBaseAttributes();
            SetBaseSecondaryAttributes();
            SetArmorReq();
            SetWeaponReq();
            NewBaseArmorAttributes();
            NewBaseWeaponAttributes();
        }
        /// <summary>
        /// Set primary attributes to starting point for Hero and calculate DPS, Hero starts at Level 1
        /// </summary>
        private void SetBaseAttributes()
        {
            BasePrimaryAttributes = HeroClass.SetBaseAttributes();
        }
        /// <summary>
        /// Set secondary attributes to starting ponit for Hero
        /// </summary>
        private void SetBaseSecondaryAttributes()
        {
            BaseSecondaryAttributes = HeroClass.SetBaseSecondaryAttributes(BasePrimaryAttributes);
        }
        /// <summary>
        /// Set Armor requirements for class
        /// Maintained in the Character class
        /// </summary>
        private void SetArmorReq()
        {
            ArmorDirectory = HeroClass.SetArmorReq();
        }
        /// <summary>
        /// Set Weapon requirements for character
        /// Maintained in the Character class
        /// </summary>
        private void SetWeaponReq()
        {
            WeaponDirectory = HeroClass.SetWeaponReq();
        }
        /// <summary>
        /// Set Base Armor properties
        /// </summary>
        private void NewBaseArmorAttributes()
        {
            BaseArmorAttribute = HeroClass.NewBaseArmorAttributes();
        }
        /// <summary>
        /// Set Base Wepon to None
        /// </summary>
        private void NewBaseWeaponAttributes()
        {
            BaseWeaponAttribute = HeroClass.NewBaseWeaponAttributes();
        }
        /// <summary>
        /// Level up Hero with (1) +1 level
        /// Then update all Primary and Secondary attributes
        /// </summary>
        /// <param name="level"></param>
        public void LevelUp(int level)
        {
            if (level != 1)
            {
                throw new InvalidLevelException(message: "Level must be 1.");
            }
            Level++;
            BasePrimaryAttributes = HeroClass.LevelUpAttributes(BasePrimaryAttributes);
            BaseSecondaryAttributes = HeroClass.LevelUpSecAttributes(BasePrimaryAttributes);
            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
        }
        /// <summary>
        /// Add posibility to re-calculate DPS
        /// </summary>
        public void ReCalcDPS()
        {
            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
        }
        /// <summary>
        /// Adding new Armor to a hero
        /// Hero.AddArmor(AvailableArmor) from ENUM Items
        /// Send BaseArmorAttribute part of Hero to PrimaryAttributes
        /// Recalculates DPS
        /// Case: first check if required Level is met, then check if type is allowed on you class. Exception if not.
        /// </summary>
        /// <param name="armor"></param>
        public void AddArmor(AvailableArmor AvailableArmor)
        {
            foreach (var availArmor in from availArmor in ArmorDirectory.ArmorList
                                       where availArmor.Key.AvailableArmor.Equals(AvailableArmor)
                                       select new { availArmor.Key })

                if (ArmorDirectory.ArmorReq.Contains(availArmor.Key.ArmorTypes))
                {
                    foreach (var newArmor in from newArmor in ArmorDirectory.ArmorList
                                             where newArmor.Key.AvailableArmor.Equals(AvailableArmor)
                                             select new { newArmor.Key })

                        if (newArmor.Key.RequiredLevel <= Level)
                        {
                            BaseArmorAttribute = newArmor.Key;
                            BasePrimaryAttributes = newArmor.Key.BasePrimaryAttributes.Add(BasePrimaryAttributes);
                            BaseSecondaryAttributes = HeroClass.LevelUpSecAttributes(BasePrimaryAttributes);
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                        }
                        else
                        {
                            throw new InvalidArmorException(message: $"You cannot use this armor! Required level for this armor is {newArmor.Key.RequiredLevel}");
                        }
                }
                else
                {
                    throw new InvalidArmorException(message: $"Your class cannot use this type of armor");
                }

            System.Console.WriteLine("New Armour equipded!");
        }
        /// <summary>
        /// Adding new Weapon to a hero
        /// Hero.AddWeapon (WeaponType, AvailableWeapon)  
        /// Recalculates DPS
        /// Case: first check if required Level is met, then check if type is allowed on you class. Exception if not.
        /// </summary>
        /// <param name="weapon"></param>
        public void AddWeapon(AvailableWeapon AvailableWeapon)
        {
            foreach (var availWeapon in from availWeapon in WeaponDirectory.WeaponList
                                        where availWeapon.Key.AvailableWeapon.Equals(AvailableWeapon)
                                        select new { availWeapon.Key })

                if (WeaponDirectory.WeaponReq.Contains(availWeapon.Key.WeaponTypes))
                {
                    foreach (var newWeapon in from newWeapon in WeaponDirectory.WeaponList
                                              where newWeapon.Key.AvailableWeapon.Equals(AvailableWeapon)
                                              select new { newWeapon.Key })

                        if (newWeapon.Key.RequiredLevel <= Level)
                        {
                            BaseWeaponAttribute = newWeapon.Key;
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                        }
                        else
                        {
                            throw new InvalidWeaponException(message: $"You cannot use this Weapon! Required level for this Weapon is {newWeapon.Key.RequiredLevel}");
                        }
                }
                else
                {
                    throw new InvalidWeaponException(message: $"Your class cannot use this type of weapon");
                }

            System.Console.WriteLine("New Weapon equipded!");
        }
        /// <summary>
        /// Show a string representation of the Hero stats
        /// </summary>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Level: {Level}");
            stringBuilder.AppendLine($"Class: {HeroTypes}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Armor: {BaseArmorAttribute.Name}");
            if (BaseArmorAttribute.SlotTypes != SlotTypes.None)
            {
                stringBuilder.AppendLine($"Armor Skill: {BaseArmorAttribute.RequiredLevel}");
                stringBuilder.AppendLine($"Armor type: {BaseArmorAttribute.ArmorTypes}");
                stringBuilder.AppendLine($"Armor slot: {BaseArmorAttribute.SlotTypes}");
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Vitality: {BasePrimaryAttributes.Vitality}");
            stringBuilder.AppendLine($"Strength: {BasePrimaryAttributes.Strength}");
            stringBuilder.AppendLine($"Dexterity: {BasePrimaryAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {BasePrimaryAttributes.Inteligence}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Health: {BaseSecondaryAttributes.Health}");
            stringBuilder.AppendLine($"Armor Rating: {BaseSecondaryAttributes.ArmorRating}");
            stringBuilder.AppendLine($"Elemental Resistance: {BaseSecondaryAttributes.ElementalResistance}");
            stringBuilder.AppendLine();
            if (BaseWeaponAttribute.SlotTypes == SlotTypes.Weapon)
            {
                stringBuilder.AppendLine($"Weapon: {BaseWeaponAttribute.Name}");
                stringBuilder.AppendLine($"Weapon Damage: {BaseWeaponAttribute.WeaponAttributes.Damage}");
                stringBuilder.AppendLine($"Weapon Attackspeed: {BaseWeaponAttribute.WeaponAttributes.AttackSpeed}");
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"DPS: {BasePrimaryAttributes.DPS}");
            return stringBuilder.ToString();
        }

    }
}
