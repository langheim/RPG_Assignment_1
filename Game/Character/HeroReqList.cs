using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RPG_Assignment_1
{
    class HeroReqList : IEnumerable<HeroReqList>
    {
        public Dictionary<Armor, ArmorTypes> HeroArmors = new();

        public Armor Cloth { get; set; } = new Armor()
        {
            Name = "Common robe body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
        };

        public Armor ClothRobe { get; set; } = new Armor()
        {
            Name = "Common robe body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
        };
        public Armor Ribbit { get; set; } = new Armor()
        {
            Name = "Common robe body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
        };

        //public ArmorList Mages { get; set; } = new ArmorList()
        //{
        //    HeroTypes = HeroTypes.Mage,
        //    ArmorTypes1 = ArmorTypes.Cloth
        //};
        //public ArmorList Rangers { get; set; } = new ArmorList()
        //{
        //    HeroTypes = HeroTypes.Ranger,
        //    ArmorTypes1 = ArmorTypes.Leather,
        //    ArmorTypes2 = ArmorTypes.Mail
        //};
        //public ArmorList Rogues { get; set; } = new ArmorList()
        //{
        //    HeroTypes = HeroTypes.Rouge,
        //    ArmorTypes1 = ArmorTypes.Leather,
        //    ArmorTypes2 = ArmorTypes.Mail
        //};
        //public ArmorList Warriors { get; set; } = new ArmorList()
        //{
        //    HeroTypes = HeroTypes.Rouge,
        //    ArmorTypes1 = ArmorTypes.Mail,
        //    ArmorTypes2 = ArmorTypes.Plate
        //};


        public HeroReqList()
        {
            HeroArmors.Add(Cloth, ArmorTypes.Cloth);
            HeroArmors.Add(ClothRobe, ArmorTypes.Cloth);
            HeroArmors.Add(Ribbit, ArmorTypes.Cloth);
            //HeroArmors.Add(Warriors);
            //HeroArmors.Add(ArmorTypes.Mail, HeroTypes.Rouge);
        }

        public IEnumerator<HeroReqList> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
