using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;
using RPG_Assignment_1.Game.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1
{
    public class EquiptmentRestrict
    {
        public Dictionary<Armor, HeroTypes> HeroArmors = new();
        public Armor Cloth { get; set; } = new Armor()
        {
            Name = "Common robe body armor",
            RequiredLevel = 1,
            SlotTypes = SlotTypes.Body,
            ArmorTypes = ArmorTypes.Cloth,
            BasePrimaryAttributes = new PrimaryAttributes { Vitality = 2, Strength = 1 }
        };

    }
}
