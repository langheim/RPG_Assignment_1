using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1
{
    public class CreateHero
    {
        public string Name { get; init; }
        public HeroTypes HeroTypes { get; init; }
        public PrimaryAttributes BasePrimaryAttributes { get; private set; }
        public SecondaryAttributes BaseSecondaryAttributes { get; set; }
        public SecondaryAttributes SetSecondaryAttributes { get; set; }
        public ArmorAttributes ArmorAttributes { get; set; }
        public WeaponAttributes WeaponAttributes { get; set; }
        public ICreateHero Attribute { get; init; }
        public ICreateHero SetSecAttribute { get; init; }

        public CreateHero(string name, HeroTypes heroTypes, ICreateHero attribute)
        {
            Name = name;
            HeroTypes = heroTypes;
            Attribute = attribute;
            SetSecAttribute = attribute;
            SetBaseAttributes();
            SetBaseSecondaryAttributes();
            SetBaseArmorAttributes();
            SetBaseWeaponAttributes();
        }
        /// <summary>
        /// Set primary attributes to starting ponit for Hero and calculate DPS, Hero starts at Level 1
        /// </summary>
        private void SetBaseAttributes()
        {
            BasePrimaryAttributes = Attribute.SetBaseAttributes();
        }
        /// <summary>
        /// Set secondary attributes to starting ponit for Hero
        /// </summary>
        private void SetBaseSecondaryAttributes()
        {
            BaseSecondaryAttributes = SetSecAttribute.SetBaseSecondaryAttributes(BasePrimaryAttributes);
        }
        /// <summary>
        /// Set Armor to None
        /// </summary>
        private void SetBaseArmorAttributes()
        {
            ArmorAttributes = Attribute.SetBaseArmorAttributes(ArmorAttributes);
        }
        /// <summary>
        /// Set Weapon to None
        /// </summary>
        private void SetBaseWeaponAttributes()
        {
            WeaponAttributes = Attribute.SetBaseWeaponAttributes(WeaponAttributes);
            BasePrimaryAttributes = Attribute.CalculateDPS(BasePrimaryAttributes, WeaponAttributes);
        }
        /// <summary>
        /// Function to level up a Hero
        /// </summary>
        public void LevelUp()
        {
            //Level up primary and secondary attributes and calculate DPS
          
            BasePrimaryAttributes = Attribute.LevelUpAttributes(BasePrimaryAttributes);
            BaseSecondaryAttributes = SetSecAttribute.LevelUpSecAttributes(BaseSecondaryAttributes);
            BasePrimaryAttributes = Attribute.CalculateDPS(BasePrimaryAttributes, WeaponAttributes);
        }
        /// <summary>
        /// Add new Armor
        /// </summary>
        public void AddNewArmor(string name, ArmorTypes armorTypes, int requiredLevel, SlotTypes slotTypes, PrimaryAttributes attributes)
        {
            var herotypes = this.HeroTypes;
            var ArmorTypes = armorTypes;

            switch (herotypes)
            {
                case HeroTypes.Mage:
                    if (armorTypes == ArmorTypes.Cloth) 
                    {
                        if (requiredLevel <= BasePrimaryAttributes.Level)
                        {
                            ArmorAttributes = new ArmorAttributes(name, armorTypes, requiredLevel, slotTypes);
                            BaseSecondaryAttributes = BaseSecondaryAttributes.Add(attributes.Vitality, attributes.Strengt + attributes.Dexterity, attributes.Inteligence);
                            break;
                        }
                        else
                            Console.WriteLine($"You cannot use {name}, required level for {name} is {requiredLevel}");
                            break;
                    }
                    else
                        Console.WriteLine($"Your {herotypes} class cannot use Armor of type {armorTypes}");
                        break;
                case HeroTypes.Ranger:
                case HeroTypes.Rouge:
                    if (armorTypes == ArmorTypes.Leather || armorTypes == ArmorTypes.Mail)
                    {
                        if (requiredLevel <= BasePrimaryAttributes.Level)
                        {
                            ArmorAttributes = new ArmorAttributes(name, armorTypes, requiredLevel, slotTypes);
                            BaseSecondaryAttributes = BaseSecondaryAttributes.Add(attributes.Vitality, attributes.Strengt + attributes.Dexterity, attributes.Inteligence);
                            break;
                        }
                        else
                            Console.WriteLine($"You cannot use {name}, required level for {name} is {requiredLevel}");
                            break;
                    }
                    else
                        Console.WriteLine($"Your {herotypes} class cannot use Armor of type {armorTypes}");
                        break;
                case HeroTypes.Warrior:
                    if (armorTypes == ArmorTypes.Mail || armorTypes == ArmorTypes.Plate)
                    {
                        if (requiredLevel <= BasePrimaryAttributes.Level)
                        {
                            ArmorAttributes = new ArmorAttributes(name, armorTypes, requiredLevel, slotTypes);
                            BaseSecondaryAttributes = BaseSecondaryAttributes.Add(attributes.Vitality, attributes.Strengt + attributes.Dexterity, attributes.Inteligence);
                            break;
                        }
                        else
                            Console.WriteLine($"You cannot use {name}, required level for {name} is {requiredLevel}");
                            break;
                    }
                    else
                        Console.WriteLine($"Your {herotypes} class cannot use Armor of type {armorTypes}");
                        break;
                default:
                    Console.WriteLine($"You are not able to use the armor named: {name} ");
                    break;
            }
            BasePrimaryAttributes = BasePrimaryAttributes.Add(attributes);
        }
        /// <summary>
        /// Add Weapon and calculate DPS
        /// </summary>
        public void AddNewWeapon(string name, WeaponTypes weaponTypes, int requiredLevel, SlotTypes slotTypes, double damage, double attackSpeed)
        {
            var herotypes = this.HeroTypes;
            
            switch (herotypes)
            {
                case HeroTypes.Rouge:
                    if ((weaponTypes == WeaponTypes.Staff || weaponTypes == WeaponTypes.Wand))
                    {
                        if (requiredLevel <= BasePrimaryAttributes.Level)
                        {
                            WeaponAttributes = new WeaponAttributes(name, weaponTypes, requiredLevel, slotTypes, damage, attackSpeed);
                            break;
                        }
                        else
                            Console.WriteLine($"You cannot pick up this weapon, required level for {name} is {requiredLevel} ");
                            break;
                    }
                    else
                        Console.WriteLine($"Your {herotypes} class cannot use this weapon of type {weaponTypes}");
                        break;
                    
                case HeroTypes.Ranger:
                case HeroTypes.Mage:
                case HeroTypes.Warrior:
                    if ((weaponTypes != WeaponTypes.Staff & weaponTypes != WeaponTypes.Wand))
                    {
                        if (requiredLevel <= BasePrimaryAttributes.Level)
                        {
                            WeaponAttributes = new WeaponAttributes(name, weaponTypes, requiredLevel, slotTypes, damage, attackSpeed);
                            break;
                        }
                        else
                            Console.WriteLine($"You cannot pick up this weapon, required level for {name} is {requiredLevel} ");
                        break;
                    }
                    else
                        Console.WriteLine($"Your {herotypes} class cannot use this weapon of type {weaponTypes}");
                    break;
                default:
                    Console.WriteLine($"You are not able to use the weapon named: {name} ");
                    break;
            }
        }



        /// <summary>
        /// Show a string representation of the Hero stats
        /// </summary>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Name: {Name}");
            stringBuilder.AppendLine($"Level: {BasePrimaryAttributes.Level}");
            stringBuilder.AppendLine($"Class: {HeroTypes}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Armor name: {ArmorAttributes.Name}");
            stringBuilder.AppendLine($"Armor type: {ArmorAttributes.ArmorTypes}");
            stringBuilder.AppendLine($"Armor slot: {ArmorAttributes.SlotTypes}");
            stringBuilder.AppendLine($"Armor Skill: {ArmorAttributes.RequiredLevel}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Vitality: {BasePrimaryAttributes.Vitality}");
            stringBuilder.AppendLine($"Strengt: {BasePrimaryAttributes.Strengt}");
            stringBuilder.AppendLine($"Dexterity: {BasePrimaryAttributes.Dexterity}");
            stringBuilder.AppendLine($"Intelligence: {BasePrimaryAttributes.Inteligence}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"Health: {BaseSecondaryAttributes.Health}");
            stringBuilder.AppendLine($"Armor Rating: {BaseSecondaryAttributes.ArmorRating}");
            stringBuilder.AppendLine($"Elemental Resistance: {BaseSecondaryAttributes.ElementalResistance}");
            stringBuilder.AppendLine();
            if (WeaponAttributes.SlotTypes == SlotTypes.Weapon)
            {
                stringBuilder.AppendLine($"Weapon: {WeaponAttributes.Name}");
                stringBuilder.AppendLine($"Weapon Damage: {WeaponAttributes.Damage}");
                stringBuilder.AppendLine($"Weapon Attackspeed: {WeaponAttributes.AttackSpeed}");
            }
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"DPS: {BasePrimaryAttributes.DPS}");
            return stringBuilder.ToString();
        }
    }
}
