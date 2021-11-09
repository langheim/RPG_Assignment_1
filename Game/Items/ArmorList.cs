using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System.Collections.Generic;

namespace RPG_Assignment_1
{
    public class ArmorLists
    {
        public Dictionary<Armor, ArmorTypes> ArmorList = new();
        public List<ArmorTypes> ArmorReq = new(); 
        
        public Armor ClothHead_Level1 { get; set; } = new Armor()
        {
            Name = "Common cloth head armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Head,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 1, Inteligence = 3 },
            AvailableArmor = AvailableArmor.ClothHead_Level1
        };
        public Armor ClothBody_Level3 { get; set; } = new Armor()
        {
            Name = "Common cloth body armor",
            RequiredLevel = 3,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Inteligence = 3 },
            AvailableArmor = AvailableArmor.ClothBody_Level3
        };
        
        public Armor PlateBody_Level1 { get; set; } = new Armor()
        {
            Name = "Plate body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Plate,
            BasePrimaryAttributes = new PrimaryAttributes { Dexterity = 2, Strength = 7 },
            AvailableArmor = AvailableArmor.PlateBody_Level1
        };
        public Armor Plate_Level4 { get; set; } = new Armor()
        {
            Name = "Major Plate body armor",
            RequiredLevel = 4,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Plate,
            BasePrimaryAttributes = new PrimaryAttributes { Dexterity = 6, Inteligence = 7 },
            AvailableArmor = AvailableArmor.Plate_Level4
        };
        public Armor LeatherHead_Levell2 { get; set; } = new Armor()
        {
            Name = "Common Leather head armor",
            RequiredLevel = 2,
            SlotTypes = SlotTypes.Head,
            ArmorTypes = ArmorTypes.Leather,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 },
            AvailableArmor = AvailableArmor.LeatherHead_Level2
        };
        public Armor LeatherBody_Level1 { get; set; } = new Armor()
        {
            Name = "Common leather body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Leather,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 1, Strength = 3 },
            AvailableArmor = AvailableArmor.LeatherBody_Level1
        };
        public Armor MailBody_Level2 { get; set; } = new Armor()
        {
            Name = "Common mail body armor",
            RequiredLevel = 2,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Mail,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 4, Strength = 4 },
            AvailableArmor = AvailableArmor.MailBody_Level2
        };
        public Armor MailHead_Level1 { get; set; } = new Armor()
        {
            Name = "Common mail head armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Head,
            ArmorTypes = ArmorTypes.Mail,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 5 },
            AvailableArmor = AvailableArmor.MailHead_Level1
        };


        public ArmorLists()
        {
            //Add objects to Items ENUM for easy access in AddArmor command
            
            ArmorList.Add(ClothHead_Level1, ArmorTypes.Cloth);
            ArmorList.Add(ClothBody_Level3, ArmorTypes.Cloth);
            ArmorList.Add(PlateBody_Level1, ArmorTypes.Plate);
            ArmorList.Add(Plate_Level4, ArmorTypes.Plate);
            ArmorList.Add(LeatherHead_Levell2, ArmorTypes.Leather);
            ArmorList.Add(LeatherBody_Level1, ArmorTypes.Leather);
            ArmorList.Add(MailBody_Level2, ArmorTypes.Mail);
            ArmorList.Add(MailHead_Level1, ArmorTypes.Mail);
        }
    }
}


