using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Assignment_1
{
    public class Mage : ICreateHero
    {
        /// <summary>
        /// Set primary attributes for Hero
        /// </summary>
        /// <returns>attributes to attribute container </returns>
        public PrimaryAttributes SetBaseAttributes()
        {
            return new PrimaryAttributes(5, 1, 1, 8, 1, 1);
        }
        /// <summary>
        /// Set secondary attributes for Hero
        /// </summary>
        /// <returns>attributes to secAttribute container </returns>
        public SecondaryAttributes SetBaseSecondaryAttributes(PrimaryAttributes attributes)
        {
            return new SecondaryAttributes(attributes.Vitality * 10, attributes.Strengt + attributes.Dexterity, attributes.Inteligence + 10) ;
        }
        /// <summary>
        /// Set base armor for Hero = None
        /// </summary>
        /// <returns>attributes to armorAttribute container </returns>
        public ArmorAttributes SetBaseArmorAttributes(ArmorAttributes armorAttribute)
        {
            return new ArmorAttributes("No Armor", ArmorTypes.None, 0, SlotTypes.None);
        }
        /// <summary>
        /// Set base weapon for Hero = None
        /// </summary>
        /// <returns>attributes to weaponAttribute container </returns>
        public WeaponAttributes SetBaseWeaponAttributes(WeaponAttributes weaponAttribute)
        {
            return new WeaponAttributes("No Weapon", WeaponTypes.None, 0, SlotTypes.None, 0, 0);
        }
        /// <summary>
        /// Level up primary attributes for Hero
        /// </summary>
        /// <returns>attributes to attribute container </returns>
        public PrimaryAttributes LevelUpAttributes(PrimaryAttributes attribute)
        {
            return attribute.Add(3, 1, 1, 5, 0, 1);
        }
        /// <summary>
        /// Level up secondary attributes for Hero
        /// </summary>
        /// <returns>attributes to secAttribute container </returns>
        public SecondaryAttributes LevelUpSecAttributes(SecondaryAttributes secAttribute)
        {
            return secAttribute.Add(50, 2, 2);
        }
        /// <summary>
        /// Calculate DPS - if no wepaon 1 * (Hero Level + (Main attribute / 100) else 
        /// (Weapon damage * Weapon attackspeed) * (Hero Level + (Main attribute / 100) 
        /// </summary>
        /// <returns>Calculated DPS to PrimaryAttributes container</returns>
        
        public PrimaryAttributes CalculateDPS(PrimaryAttributes attribute, WeaponAttributes weaponAttribute)
        {
            //Main Attribute for a Mage is Inteligence
            double mainAttribute = attribute.Inteligence / 100;
            double levelAndAttr = attribute.Level + mainAttribute;
            if (weaponAttribute.WeaponTypes != WeaponTypes.None)
            {
                double weapon = weaponAttribute.Damage * weaponAttribute.AttackSpeed;
                double dps = weapon * levelAndAttr;
                return attribute.AddDPS(dps);
            }
            else
            {
                double dps = 1 * levelAndAttr;
                return attribute.AddDPS(dps);
            }
        }

    }


}

   