using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System.Collections.Generic;

namespace RPG_Assignment_1.Game.Items
{
    public class WeaponLists
    {
        public Dictionary<Weapon, WeaponTypes> WeaponList = new();
        public List<WeaponTypes> WeaponReq = new();

        //Add Weapons to Directory
        public Weapon Axe_Level1 { get; set; } = new Weapon()
        {
            Name = "Common axe",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Axe,
            WeaponAttributes = new WeaponAttributes { Damage = 7, AttackSpeed = 1.1 },
            AvailableWeapon = AvailableWeapon.Axe_Level1
    };
        public Weapon Staff_Level1 { get; set; } = new Weapon()
        {
            Name = "Common Staff",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Staff,
            WeaponAttributes = new WeaponAttributes { Damage = 2, AttackSpeed = 1.3 },
            AvailableWeapon = AvailableWeapon.Staff_Level1
        };
        public Weapon Bow_Level1 { get; set; } = new Weapon()
        {
            Name = "Common Bow",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Bow,
            WeaponAttributes = new WeaponAttributes { Damage = 3, AttackSpeed = 1.0 },
            AvailableWeapon = AvailableWeapon.Bow_Level1
        };
        public Weapon Dagger_Level1 { get; set; } = new Weapon()
        {
            Name = "Common Dagger",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Dagger,
            WeaponAttributes = new WeaponAttributes { Damage = 1, AttackSpeed = 1.8 },
            AvailableWeapon = AvailableWeapon.Dagger_Level1
        };
        public Weapon Hammer_Level1 { get; set; } = new Weapon()
        {
            Name = "Common Hammer",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Hammer,
            WeaponAttributes = new WeaponAttributes { Damage = 4, AttackSpeed = 1.1 },
            AvailableWeapon = AvailableWeapon.Hammer_Level1
        };
        public Weapon Sword_Level1 { get; set; } = new Weapon()
        {
            Name = "Common Sword",
            RequiredLevel = 3,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Sword,
            WeaponAttributes = new WeaponAttributes { Damage = 8, AttackSpeed = 1.3 },
            AvailableWeapon = AvailableWeapon.Sword_Level1
        };
        public Weapon Wand_Level2 { get; set; } = new Weapon()
        {
            Name = "Common Wand",
            RequiredLevel = 2,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Wand,
            WeaponAttributes = new WeaponAttributes { Damage = 3, AttackSpeed = 2.3 },
            AvailableWeapon = AvailableWeapon.Wand_Level2
        };
        public Weapon GreatSword_Level5 { get; set; } = new Weapon()
        {
            Name = "Great Sword",
            RequiredLevel = 5,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Sword,
            WeaponAttributes = new WeaponAttributes { Damage = 15, AttackSpeed = 1.1 },
            AvailableWeapon = AvailableWeapon.GreatSword_Level5
        };
        public Weapon GreatWand_Level7 { get; set; } = new Weapon()
        {
            Name = "Big Wand",
            RequiredLevel = 7,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Wand,
            WeaponAttributes = new WeaponAttributes { Damage = 12, AttackSpeed = 2.0 },
            AvailableWeapon = AvailableWeapon.GreatWand_Level7
        };
        public Weapon GreatBow_Level8 { get; set; } = new Weapon()
        {
            Name = "Great Bow",
            RequiredLevel = 8,
            SlotTypes = SlotTypes.Weapon,
            WeaponTypes = WeaponTypes.Bow,
            WeaponAttributes = new WeaponAttributes { Damage = 12, AttackSpeed = 2.0 },
            AvailableWeapon = AvailableWeapon.GreatBow_Level8
        };

        public WeaponLists()
        {
            //Add objects to Items ENUM for easy access in AddWeapon command

            WeaponList.Add(Axe_Level1, WeaponTypes.Axe);
            WeaponList.Add(Staff_Level1, WeaponTypes.Staff);
            WeaponList.Add(Bow_Level1, WeaponTypes.Bow);
            WeaponList.Add(Dagger_Level1, WeaponTypes.Dagger);
            WeaponList.Add(Hammer_Level1, WeaponTypes.Hammer);
            WeaponList.Add(Sword_Level1, WeaponTypes.Sword);
            WeaponList.Add(Wand_Level2, WeaponTypes.Wand);
            WeaponList.Add(GreatSword_Level5, WeaponTypes.Sword);
            WeaponList.Add(GreatWand_Level7, WeaponTypes.Wand);
            WeaponList.Add(GreatBow_Level8, WeaponTypes.Bow);
        }
    }
}
