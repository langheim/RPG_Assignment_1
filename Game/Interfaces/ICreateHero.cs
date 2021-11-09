using RPG_Assignment_1.Game.Attributes;
using RPG_Assignment_1.Game.Functions;
using RPG_Assignment_1.Game.Items;

namespace RPG_Assignment_1.Game.Interfaces
{
    public interface ICreateHero
    {
        /// <summary>
        /// Set requirements for what Weapon the class can use
        /// </summary>
        /// <returns></returns>
        WeaponLists SetWeaponReq();
        /// <summary>
        /// Set requirements for what Armor the class can use
        /// </summary>
        /// <returns></returns>
        ArmorLists SetArmorReq();
        /// <summary>
        /// Set primary attributes for Hero
        /// </summary>
        /// <returns>BaseAttributes to Primaryattribute Basecontainer </returns>
        PrimaryAttributes SetBaseAttributes();
        /// <summary>
        /// Get Hero's main Attribute
        /// </summary>
        /// <returns></returns>
        int GetMainAttribute(PrimaryAttributes attribute);
        /// <summary>
        /// Set secondary attributes for Hero
        /// </summary>
        /// <returns>SecondaryAttributes to SecondaryAttribute container </returns>
        SecondaryAttributes SetBaseSecondaryAttributes(PrimaryAttributes attribute);
        /// <summary>
        /// Set base armor for Hero = None
        /// </summary>
        /// <returns>Attributes to armorAttribute container </returns>
        Armor NewBaseArmorAttributes();
        /// <summary>
        /// Set base weapon for Hero = None
        /// </summary>
        /// <returns>Attributes to weaponAttribute container </returns>
        Weapon NewBaseWeaponAttributes();
        /// <summary>
        /// Level up primary attributes for Hero
        /// </summary>
        /// <returns>Attributes to Primaryattribute container </returns>
        PrimaryAttributes LevelUpAttributes(PrimaryAttributes attribute);
        /// <summary>
        /// Level up secondary attributes for Hero
        /// </summary>
        /// <returns>Attributes to secAttribute container </returns>
        SecondaryAttributes LevelUpSecAttributes(PrimaryAttributes attributes);
        /// <summary>
        /// Calculate DPS 
        /// </summary>
        /// <returns>dps</returns>
        PrimaryAttributes CalculateDps(PrimaryAttributes attribute, Weapon BaseWeaponAttribute);
    }
}
