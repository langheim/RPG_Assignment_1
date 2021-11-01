using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1
{
    public interface ICreateHero
    {
        PrimaryAttributes SetBaseAttributes();
        SecondaryAttributes SetBaseSecondaryAttributes(PrimaryAttributes attributes);
        ArmorAttributes SetBaseArmorAttributes(ArmorAttributes armorAttribute);
        WeaponAttributes SetBaseWeaponAttributes(WeaponAttributes weaponAttribute);
        PrimaryAttributes LevelUpAttributes(PrimaryAttributes attribute);
        SecondaryAttributes LevelUpSecAttributes(SecondaryAttributes secAttribute);
        PrimaryAttributes CalculateDPS(PrimaryAttributes attribute, WeaponAttributes weaponAttribute);
    }
}
