using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Enums;

namespace RPG_Assignment_1.Game.Functions
{
    public class Weapon : Items
    {
        public WeaponTypes WeaponTypes { get; set; }
        public WeaponAttributes WeaponAttributes { get; set; }


        public Weapon()
        {
        }
        public Weapon(string name, int requiredLevel, SlotTypes slotTypes, WeaponTypes weaponTypes)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            SlotTypes = slotTypes;
            WeaponTypes = weaponTypes;
        }
    }
}
