using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System.Collections.Generic;

namespace RPG_Assignment_1
{
    public class ItemsLists
    {
        public Dictionary<object, SlotTypes> ArmorList = new();
        public Dictionary<object, SlotTypes> WeaponList = new();
        public Armor MailHead { get; set; } = new Armor()
        {
            Name = "Common mail head armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Head,
            ArmorTypes = ArmorTypes.Mail,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 5 }
        };
        public Armor ClothHead { get; set; } = new Armor()
        {
            Name = "Common cloth head armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Head,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 1, Inteligence = 3 }
        };
        public Armor ClothBody { get; set; } = new Armor()
        {
            Name = "Common cloth body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Inteligence = 3 }
        };
        public Armor PlateBody { get; set; } = new Armor()
        {
            Name = "Major plate body armor",
            RequiredLevel = 5,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Plate,
            BasePrimaryAttributes = new PrimaryAttributes { Dexterity = 2, Strength = 7 }
        };
        public Armor ClothRoab { get; set; } = new Armor()
        {
            Name = "Major mage body armor",
            RequiredLevel = 4,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Dexterity = 6, Inteligence = 7 }
        };
        public Armor LeatherHead { get; set; } = new Armor()
        {
            Name = "Common Leather head armor",
            RequiredLevel = 2,
            SlotTypes = SlotTypes.Head,
            ArmorTypes = ArmorTypes.Leather,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
        };
        public Armor LeatherBody { get; set; } = new Armor()
        {
            Name = "Common leather body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Leather,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 1, Strength = 3 }
        };
        public Armor MailBody { get; set; } = new Armor()
        {
            Name = "Common mail body armor",
            RequiredLevel = 2,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Mail,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 4, Strength = 4 }
        };





        //Add Weapons to Directory
        public Weapon Axe { get; set; } = new Weapon()
        {
            Name = "Common axe",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Axe,
            WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 }
        };
        public Weapon Staff { get; set; } = new Weapon()
        {
            Name = "Common Staff",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Staff,
            WeaponAttributes = new WeaponAttributes { Damage = 2, AttackSpeed = 1.3 }
        };
        public Weapon Bow { get; set; } = new Weapon()
        {
            Name = "Common Bow",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Bow,
            WeaponAttributes = new WeaponAttributes { Damage = 3, AttackSpeed = 1.0 }
        };
        public Weapon Dagger { get; set; } = new Weapon()
        {
            Name = "Common Dagger",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Dagger,
            WeaponAttributes = new WeaponAttributes { Damage = 1, AttackSpeed = 1.8 }
        };
        public Weapon Hammer { get; set; } = new Weapon()
        {
            Name = "Common Hammer",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Hammer,
            WeaponAttributes = new WeaponAttributes { Damage = 4, AttackSpeed = 1.1 }
        };
        public Weapon Sword { get; set; } = new Weapon()
        {
            Name = "Common Sword",
            RequiredLevel = 3,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Sword,
            WeaponAttributes = new WeaponAttributes { Damage = 8, AttackSpeed = 1.3 }
        };
        public Weapon Wand { get; set; } = new Weapon()
        {
            Name = "Common Wand",
            RequiredLevel = 2,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Wand,
            WeaponAttributes = new WeaponAttributes { Damage = 3, AttackSpeed = 2.3 }
        };
        public Weapon GreatSword { get; set; } = new Weapon()
        {
            Name = "Great Sword",
            RequiredLevel = 5,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Sword,
            WeaponAttributes = new WeaponAttributes { Damage = 15, AttackSpeed = 1.1 }
        };
        public Weapon GreatWand { get; set; } = new Weapon()
        {
            Name = "Big Wand",
            RequiredLevel = 7,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Wand,
            WeaponAttributes = new WeaponAttributes { Damage = 12, AttackSpeed = 2.0 }
        };
        public Weapon GreatBow { get; set; } = new Weapon()
        {
            Name = "Great Bow",
            RequiredLevel = 8,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Bow,
            WeaponAttributes = new WeaponAttributes { Damage = 12, AttackSpeed = 2.0 }
        };


        public ItemsLists()
        {

            ArmorList.Add(MailHead, SlotTypes.Head);
            ArmorList.Add(ClothHead, SlotTypes.Head);
            ArmorList.Add(ClothBody, SlotTypes.Body);
            ArmorList.Add(PlateBody, SlotTypes.Body);
            ArmorList.Add(ClothRoab, SlotTypes.Body);
            ArmorList.Add(LeatherHead, SlotTypes.Head);
            ArmorList.Add(LeatherBody, SlotTypes.Body);
            ArmorList.Add(MailBody, SlotTypes.Body);

            WeaponList.Add(Axe, SlotTypes.Weapon);
            WeaponList.Add(Staff, SlotTypes.Weapon);
            WeaponList.Add(Bow, SlotTypes.Weapon);
            WeaponList.Add(Dagger, SlotTypes.Weapon);
            WeaponList.Add(Hammer, SlotTypes.Weapon);
            WeaponList.Add(Sword, SlotTypes.Weapon);
            WeaponList.Add(Wand, SlotTypes.Weapon);
            WeaponList.Add(GreatSword, SlotTypes.Weapon);
            WeaponList.Add(GreatWand, SlotTypes.Weapon);
            WeaponList.Add(Bow, SlotTypes.Weapon);


        }

    }

}


