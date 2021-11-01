using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1
{
    public class ArmorAttributes : Items
    {

        public ArmorTypes ArmorTypes { get; set; }

        public ArmorAttributes(string name, ArmorTypes armorTypes, int requiredLevel, SlotTypes slotTypes)
        {
            Name = name;
            ArmorTypes = armorTypes;
            RequiredLevel = requiredLevel;
            SlotTypes = slotTypes;
            
        }
        public ArmorAttributes Add(ArmorAttributes armorAttribute)
        {
            ArmorTypes = armorAttribute.ArmorTypes;
            RequiredLevel = armorAttribute.RequiredLevel;
            SlotTypes = armorAttribute.SlotTypes;
            return this;
        }

        public ArmorAttributes Add(ArmorTypes armorTypes, int requiredLevel, SlotTypes slotTypes)
        {
            ArmorTypes = armorTypes;
            RequiredLevel = requiredLevel;
            SlotTypes = slotTypes;
            return this;
        }
    }
}
