using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;

namespace RPG_Assignment_1.Game.Functions
{
    public class Armor : Items
    {
        public ArmorTypes ArmorTypes { get; set; }
        public PrimaryAttributes BasePrimaryAttributes { get; init; }
        public AvailableArmor AvailableArmor { get; set; }

        public Armor()
        {
        }
        public Armor(string name, int requiredLevel, SlotTypes slotTypes, ArmorTypes armorTypes)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            SlotTypes = slotTypes;
            ArmorTypes = armorTypes;
        }
    }
}
