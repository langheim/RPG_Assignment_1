using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System.Collections.Generic;

namespace RPG_Assignment_1
{
    public class ItemTests
    {
        public List<Armor> ArmorList = new();
        public Armor MailHead { get; set; } = new Armor()
        {
            Name = "Common plate body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Plate,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
        };



        public ItemTests()
        {

            ArmorList.Add(MailHead);

        }

    }

}


