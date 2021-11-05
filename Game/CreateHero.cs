using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using RPG_Assignment_1.Game.Interfaces;
using System.Text;

namespace RPG_Assignment_1.Game
{
    public class CreateHero
    {
        public string Name { get; init; }
        public int Level { get; private set; } = 1;
        public HeroTypes HeroTypes { get; init; }
        public PrimaryAttributes BasePrimaryAttributes { get; private set; }
        public SecondaryAttributes BaseSecondaryAttributes { get; set; }
        public Armor BaseArmorAttribute { get; set; }
        public Weapon BaseWeaponAttribute { get; set; }
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
        /// Hero.AddArmor takes parameterless constructor inputs and sets it to BaseArmorAttribute
        /// Send BaseArmorAttribute part of Hero to PrimaryAttributes
        /// Recalculates DPS
        /// Case: first check if required Level is met, then check if type is allowed on you class. Exception if not.
        /// </summary>
        /// <param name="armor"></param>
        public void AddArmor(Armor armor)
        {
            switch (HeroTypes)
            {
                case HeroTypes.Mage:
                    if (armor.ArmorTypes == ArmorTypes.Cloth)
                    {
                        if (armor.RequiredLevel <= Level)
                        {
                            BaseArmorAttribute = armor;
                            BasePrimaryAttributes = armor.BasePrimaryAttributes.Add(BasePrimaryAttributes);
                            BaseSecondaryAttributes = HeroClass.LevelUpSecAttributes(BasePrimaryAttributes);
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidArmorException(message: $"You cannot use {armor.Name}, required level for {armor.Name} is {armor.RequiredLevel}");
                    }
                    else
                        throw new InvalidArmorException(message: $"Your {HeroTypes} class cannot use Armor of type {armor.ArmorTypes}");
                case HeroTypes.Ranger:
                case HeroTypes.Rouge:
                    if (armor.ArmorTypes == ArmorTypes.Leather || armor.ArmorTypes == ArmorTypes.Mail)
                    {
                        if (armor.RequiredLevel <= Level)
                        {
                            BaseArmorAttribute = armor;
                            BasePrimaryAttributes = armor.BasePrimaryAttributes.Add(BasePrimaryAttributes);
                            BaseSecondaryAttributes = HeroClass.LevelUpSecAttributes(BasePrimaryAttributes);
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidArmorException(message: $"You cannot use {armor.Name}, required level for {armor.Name} is {armor.RequiredLevel}");
                    }
                    else
                        throw new InvalidArmorException(message: $"Your {HeroTypes} class cannot use Armor of type {armor.ArmorTypes}");
                case HeroTypes.Warrior:
                    if (armor.ArmorTypes == ArmorTypes.Mail || armor.ArmorTypes == ArmorTypes.Plate)
                    {
                        if (armor.RequiredLevel <= Level)
                        {
                            BaseArmorAttribute = armor;
                            BasePrimaryAttributes = armor.BasePrimaryAttributes.Add(BasePrimaryAttributes);
                            BaseSecondaryAttributes = HeroClass.LevelUpSecAttributes(BasePrimaryAttributes);
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidArmorException(message: $"You cannot use {armor.Name}, required level for {armor.Name} is {armor.RequiredLevel}");
                    }
                    else
                        throw new InvalidArmorException(message: $"Your {HeroTypes} class cannot use Armor of type {armor.ArmorTypes}");
                default:
                    throw new InvalidArmorException(message: $"You are not able to use the armor named: {armor.Name} ");
            }

            System.Console.WriteLine("New Armour equipded!");
        }
        /// <summary>
        /// Adding new Armor to a hero
        /// Hero.AddWeapon takes parameterless constructor inputs as input and sets it to BaseWeaponAttribute
        /// Recalculates DPS
        /// Case: first check if required Level is met, then check if type is allowed on you class. Exception if not.
        /// </summary>
        /// <param name="weapon"></param>
        public void AddWeapon(Weapon weapon)
        {
            switch (HeroTypes)
            {
                case HeroTypes.Mage:
                    if (weapon.WeaponTypes == WeaponTypes.Staff || weapon.WeaponTypes == WeaponTypes.Wand)
                    {
                        if (weapon.RequiredLevel <= Level)
                        {
                            BaseWeaponAttribute = weapon;
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidWeaponException(message: $"You cannot use {weapon.Name}, required level for {weapon.Name} is {weapon.RequiredLevel}");
                    }
                    else
                        throw new InvalidWeaponException(message: $"Your {HeroTypes} class cannot use the weapon {weapon.WeaponTypes}");
                case HeroTypes.Ranger:
                    if (weapon.WeaponTypes == WeaponTypes.Bow)
                    {
                        if (weapon.RequiredLevel <= Level)
                        {
                            BaseWeaponAttribute = weapon;
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidWeaponException(message: $"You cannot use {weapon.Name}, required level for {weapon.Name} is {weapon.RequiredLevel}");
                    }
                    else
                        throw new InvalidWeaponException(message: $"Your {HeroTypes} class cannot use the weapon {weapon.WeaponTypes}");
                case HeroTypes.Rouge:
                    if (weapon.WeaponTypes == WeaponTypes.Dagger || weapon.WeaponTypes == WeaponTypes.Sword)
                    {
                        if (weapon.RequiredLevel <= Level)
                        {
                            BaseWeaponAttribute = weapon;
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidWeaponException(message: $"You cannot use {weapon.Name}, required level for {weapon.Name} is {weapon.RequiredLevel}");
                    }
                    else
                        throw new InvalidWeaponException(message: $"Your {HeroTypes} class cannot use the weapon {weapon.WeaponTypes}");
                case HeroTypes.Warrior:
                    if (weapon.WeaponTypes == WeaponTypes.Axe || weapon.WeaponTypes == WeaponTypes.Hammer || weapon.WeaponTypes == WeaponTypes.Sword)
                    {
                        if (weapon.RequiredLevel <= Level)
                        {
                            BaseWeaponAttribute = weapon;
                            BasePrimaryAttributes = HeroClass.CalculateDps(BasePrimaryAttributes, BaseWeaponAttribute);
                            break;
                        }
                        else
                            throw new InvalidWeaponException(message: $"You cannot use {weapon.Name}, required level for {weapon.Name} is {weapon.RequiredLevel}");
                    }
                    else
                        throw new InvalidWeaponException(message: $"Your {HeroTypes} class cannot use the weapon {weapon.WeaponTypes}");
                default:
                    throw new InvalidWeaponException(message: $"You are not able to use the weapon named: {weapon.Name} ");
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
